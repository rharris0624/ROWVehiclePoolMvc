using Microsoft.EntityFrameworkCore;
using RowVehiclePoolMVC.ViewModels;
using RowVehiclePoolMVC.Context;
using System.Collections.Generic;
using System.Linq;
using System;
using System.DirectoryServices;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.CodeAnalysis.Differencing;
//using static Microsoft.EntityFrameworkCore.Internal.DbContextPool<TContext>;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using RowVehiclePoolMVC.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Identity.Abstractions;
using Microsoft.Identity.Web;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.Utilities
{
    public static class Utility
    {
        public static String GetEmailRecipients()
        {
            String returnString = null;
            try
            {
                using (var securityContext = new RvpAppSecurityContext())
                {
                    var userIdList = securityContext.SystemSec.Where(c => c.ReceiveMail.ToUpper() == "Y" && c.SystemId == "WRVP").Select(c => c.Userid.Trim()).Distinct().ToList();
                    if(userIdList != null && userIdList.Count > 0)
                    {
                        foreach (var userId in userIdList)
                        {
                            returnString = returnString + GetEmailAddress(userId).Trim() + ";";
                        }
                        returnString = returnString.Substring(0, returnString.Length - 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail RecipientList Failed: {0}",ex.Message);
            }
            return returnString;
        }

        public static VehicleWeekVM GetVehicleWeek(RvpAppContext context, string sDate)
        {
            DateTime dDate;
            if (!DateTime.TryParse(sDate, out dDate))
            {
                dDate = DateTime.Now;
            }
            var dayOfWeek = dDate.DayOfWeek;
            var firstDayOfWeek = dDate.AddDays(-(int)dayOfWeek + 1);
            var lastDayOfWeek = firstDayOfWeek.AddDays(6);
            IList<WeeklyVehicleUsage> weeklyVehicleUsages = new List<WeeklyVehicleUsage>();

            //Create a list of vehicles ordered by type and tag number
            //Create a list of assignments in the range of the first and last days of the week
            //populate the view model with the vehicles and assignments
            
            var vehicles = context.Vehicle.Where(c => !c.Status.Equals("i")).OrderBy(c => c.VehicleType).ThenBy(c => c.TagNumber).ToList();
            
            IList<UsageInstance> usageInstances = null;
            try
            {
                usageInstances = context.VehicleAssignment.Join(context.VehicleRequisition, vAssign => vAssign.VehReqNo, vRequest => vRequest.VehReqNo, (vAssign, vRequest) => new { vAssign, vRequest })
                .Where(c => c.vAssign.AssignDepartDate.Date >= firstDayOfWeek.Date && c.vAssign.AssignDepartDate.Date <= lastDayOfWeek.Date)
                .Select(c => new UsageInstance
                {
                    Requestor = c.vRequest.Requestor,
                    TagNumber = c.vAssign.AssignTagNo,
                    AssignNo = c.vAssign.AssignNo,
                    UsageDepartDate = c.vAssign.AssignDepartDate,
                    UsageReturnDate = c.vAssign.AssignReturnDate,
                }).OrderBy(c => c.TagNumber).ThenBy(c => c.AssignNo).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
                throw;
            }
            var vehicleWeekVM = new VehicleWeekVM(vehicles, usageInstances, dDate);
            return vehicleWeekVM;
        }

        public static string GetEmailAddress(string userid)
        {
            string returnString = null;
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://AHTD.com/OU=Employees,OU=Users,OU=ARDOT,DC=AHTD,DC=com", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(sAMaccountName=" + userid + "))");
                ds.PropertiesToLoad.Add("0");
                ds.PropertiesToLoad.Add("mail");
                // Below statement will list all entries immediately below your BaseDN
                var results = ds.FindAll();
                returnString = results[0].Properties["mail"][0].ToString().Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return returnString;
        }
        public static string GetUserId(string emailAddress)
        {
            string returnString = null;
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://AHTD.com/OU=Employees,OU=Users,OU=ARDOT,DC=AHTD,DC=com", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(mail=" + emailAddress + "))");
                ds.PropertiesToLoad.Add("0");
                ds.PropertiesToLoad.Add("sAMaccountName");
                // Below statement will list all entries immediately below your BaseDN
                var results = ds.FindAll();
                returnString = results[0].Properties["sAMaccountName"][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return returnString;
        }
        public static UserInfo GetUserInfo(string userid)
        {
            UserInfo userInfo = null;
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://AHTD.com/OU=Employees,OU=Users,OU=ARDOT,DC=AHTD,DC=com", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(objectCategory=User)(objectClass=person)(sAMaccountname=" + userid + "))");

                //ds = new DirectorySearcher(entry, "(&(objectCategory=User)(objectClass=person))");

                ds.PropertiesToLoad.Add("mail");
                ds.PropertiesToLoad.Add("extensionAttribute4");
                ds.PropertiesToLoad.Add("extensionAttribute5");
                ds.PropertiesToLoad.Add("extensionAttribute6");
                ds.PropertiesToLoad.Add("physicalDeliveryOfficeName");
                ds.PropertiesToLoad.Add("department");
                ds.PropertiesToLoad.Add("title");
                ds.PropertiesToLoad.Add("name");
                ds.PropertiesToLoad.Add("sAMaccountName");
                ds.PropertiesToLoad.Add("cn");
                // Below statement will list all entries immediately below your BaseDN
                var results = ds.FindAll();

                foreach (System.DirectoryServices.SearchResult sr in results)
                {
                    userInfo = new UserInfo();
                    userInfo.Name = sr.Properties["name"].Count > 0 ? sr.Properties["name"][0].ToString() : null;
                    userInfo.Budget = sr.Properties["extensionAttribute4"].Count > 0 ? sr.Properties["ExtensionAttribute4"][0].ToString() : null;
                    userInfo.Group = sr.Properties["extensionAttribute5"].Count > 0 ? sr.Properties["extensionAttribute5"][0].ToString() : null;
                    userInfo.EmployeeNumber = sr.Properties["extensionAttribute6"].Count > 0 ? sr.Properties["extensionAttribute6"][0].ToString() : null;
                    userInfo.Office = sr.Properties["physicalDeliveryOfficeName"].Count > 0 ? sr.Properties["physicalDeliveryOfficeName"][0].ToString() : null;
                    userInfo.Department = sr.Properties["department"].Count > 0 ? userInfo.Department = sr.Properties["department"][0].ToString() : null;
                    userInfo.Title = sr.Properties["title"].Count > 0 ? sr.Properties["title"][0].ToString() : null;
                    userInfo.cn = sr.Properties["cn"].Count > 0 ? sr.Properties["cn"][0].ToString() : null;
                    userInfo.UserId = sr.Properties["sAMaccountName"].Count > 0 ? sr.Properties["sAMaccountName"][0].ToString() : null;
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return userInfo;
        }
        // GET: VehicleRequisitions/Create

        public static string GetDivHeadEmail(string budget, string office)
        {
#if DEBUG == true
            budget = "120";
#endif
            string returnString = null;
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://DC-11", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(mail=Division*" + DefaultAddress("Division") + "))");
                ds.PropertiesToLoad.Add("physicalDeliveryOfficeName");
                ds.PropertiesToLoad.Add("member");
                ds.PropertiesToLoad.Add("mail");
                ds.PropertiesToLoad.Add("adspath");
                ds.PropertiesToLoad.Add("subtree");
                var result = ds.FindAll();

                string dhmail = null;
                int dhnf = 1;
                foreach( var sr in result[0].Properties["member"])
                {
                    var member = sr.ToString();
                    DirectoryEntry entry2 = new DirectoryEntry("LDAP://DC-11/" + member , username, passwd, AuthenticationTypes.None);
                    ds = new DirectorySearcher(entry2, "(&(ExtensionAttribute4=" + budget + ")(physicalDeliveryOfficeName=" + office + "))");
                    ds.PropertiesToLoad.Add("o");
                    ds.PropertiesToLoad.Add("ExtensionAttribute5");
                    ds.PropertiesToLoad.Add("ExtensionAttribute4");
                    ds.PropertiesToLoad.Add("physicalDeliveryOfficeName");
                    ds.PropertiesToLoad.Add("objectClass");
                    ds.PropertiesToLoad.Add("cn");
                    ds.PropertiesToLoad.Add("mail");
                    ds.PropertiesToLoad.Add("adspath");
                    ds.PropertiesToLoad.Add("department");
                    ds.PropertiesToLoad.Add("title");
                    ds.PropertiesToLoad.Add("subtree");
                    var sr2 = ds.FindOne();
                    if (sr2 != null &&  sr2.Properties["title"][0].ToString().ToUpper().Contains("DIVISION HEAD"))
                    {
                        dhmail = sr2.Properties["mail"][0].ToString();
                        dhnf = 0;
                        break;
                    }
                }
                returnString = dhmail ?? "Division Head Not found";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return returnString;
        }
        public static string DefaultAddress(string mailstr)
        {
            string returnVal = null;
            //            qstr = "<LDAP://DC-11>;(&(mail=Division*" & DefaultAddress("Division") & "));physicalDeliveryOfficeName,member,mail,adspath;subtree"
            //If you are not sure about username and password, leave below 2 variables as it is
            String username = "AHTD\\LDAP";        //Change to your username, if you have any
            String passwd = "LDAPsearch";           //Change to your Password, if you have any


            DirectoryEntry entry = new DirectoryEntry("LDAP://DC-11", username, passwd, AuthenticationTypes.None);
            DirectorySearcher ds = new DirectorySearcher(entry, "(&(mail="+mailstr.TrimEnd()+"*))");
            ds.PropertiesToLoad.Add("mail");
            ds.PropertiesToLoad.Add("sAMaccountName");
            var sr = ds.FindOne();

            if(sr != null)
            {
                returnVal = sr.Properties["mail"][0].ToString();
                returnVal = returnVal.Substring(returnVal.IndexOf("@"));
            }
            else
            {
                returnVal = "@ardot.gov";
            }
            return returnVal;
        }
        public static EmployeeInfoVM GetEmployeeInfo(string employeeNumber, RvpAppContext rowContext)
        {
            EmployeeInfoVM employeeInfo = null;

            try
            {
                //IEnumerable<VwRowEmployees>
                //.Where(s => s.JobTitle.ToUpper().Contains("SECTION HEAD") || s.JobTitle.ToUpper().Contains("DIVISION HEAD"))
                var deptHeads = rowContext.VwRowEmployees.Where(s => s.JobTitle.ToUpper().Contains("SECTION HEAD") || s.JobTitle.ToUpper().Contains("DIVISION HEAD")).GroupBy(g => g.SectionId).Select(y => new { SectionId = y.Key, Item = y.Min(g => g.Item) }).AsEnumerable();
                var divHeadEmpNum = rowContext.VwRowEmployees.Where(s => s.JobTitle.ToUpper().Equals("DIVISION HEAD")).FirstOrDefault().EmployeeNumber;
                var deptHead = rowContext.VwRowEmployees.Join(deptHeads, ei => new { ei.SectionId, ei.Item }, dh => new { dh.SectionId, dh.Item }, (d, e) => new { d, e }).Select(p => new
                {
                    p.e.SectionId,
                    p.e.Item,
                    p.d.SectionDesc,
                    SectionManagerNum = p.d.EmployeeNumber,
                    SectionManagerLastName = p.d.NameLast,
                    SectionManagerFirstName = p.d.NameFirst
                }).AsEnumerable();
                employeeInfo = rowContext.VwRowEmployees.GroupJoin(deptHead, p => new { p.SectionId }, e => new { e.SectionId }, (f, g) => new { f, g }).SelectMany(f => f.g.DefaultIfEmpty(),
                                                                                                                    (f, g)
                                                                                                                    => new EmployeeInfoVM
                                                                                                                    {
                                                                                                                        EmployeeNumber = f.f.EmployeeNumber,
                                                                                                                        FirstName = f.f.NameFirst,
                                                                                                                        LastName = f.f.NameLast,
                                                                                                                        SectionId = f.f.SectionId,
                                                                                                                        SectionDesc = f.f.SectionDesc,
                                                                                                                        SectionManagerEmail = GetEmailFromEmployeeNumber(g.SectionManagerNum),
                                                                                                                        DivisionHeadEmail = GetEmailFromEmployeeNumber(divHeadEmpNum),
                                                                                                                        SectionManagerFirstName = g.SectionManagerFirstName,
                                                                                                                        SectionManagerLastName = g.SectionManagerLastName
                                                                                                                    }).Where(p => p.EmployeeNumber.Equals(employeeNumber)).FirstOrDefault();


                return employeeInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        private static string GetEmailFromEmployeeNumber(string employeeNumber)
        {
            var returnVal = "";
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://AHTD.com/OU=Employees,OU=Users,OU=ARDOT,DC=AHTD,DC=com", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(ExtensionAttribute6=" + employeeNumber + "))");
                //ds = new DirectorySearcher(entry, "(&(objectCategory=User)(objectClass=person))");
                ds.PropertiesToLoad.Add("0");
                ds.PropertiesToLoad.Add("mail");
                // Below statement will list all entries immediately below your BaseDN
                var results = ds.FindOne();

                returnVal = results != null ? returnVal = results.Properties["mail"][0].ToString() : "Not Found";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return returnVal;
        }

        public static string GetDivisionHead(string budget)
        {
            string divisionHead = null;
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://AHTD.com/OU=Employees,OU=Users,OU=ARDOT,DC=AHTD,DC=com", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(ExtensionAttribute4=" + budget + "))");
                //ds = new DirectorySearcher(entry, "(&(objectCategory=User)(objectClass=person))");
                ds.PropertiesToLoad.Add("0");
                ds.PropertiesToLoad.Add("mail");
                ds.PropertiesToLoad.Add("extensionAttribute4");
                ds.PropertiesToLoad.Add("extensionAttribute5");
                ds.PropertiesToLoad.Add("physicalDeliveryOfficeName");
                ds.PropertiesToLoad.Add("subtree");
                ds.PropertiesToLoad.Add("adspath");
                ds.PropertiesToLoad.Add("cn");
                ds.PropertiesToLoad.Add("objectClass");
                ds.PropertiesToLoad.Add("department");
                ds.PropertiesToLoad.Add("title");
                // Below statement will list all entries immediately below your BaseDN
                var results = ds.FindAll();

                foreach (System.DirectoryServices.SearchResult sr in results)
                {
                    if (sr.Properties["department"][0].ToString().ToLower().Contains("right of way") && sr.Properties["Title"][0].ToString().ToUpper().Contains("DIVISION HEAD"))
                    {
                        divisionHead = sr.Properties["mail"][0].ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return divisionHead ?? "No Division Head Found";
        }
    }
}
