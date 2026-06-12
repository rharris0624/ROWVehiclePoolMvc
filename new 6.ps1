# Reference: https://docs.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0&tabs=http

#Application Permission:
#- Application.ReadWrite.OwnedBy
#- Application.ReadWrite.All



#Graph API Details
$MSGRAPHAPI_clientID = 'c84561fa-1e13-444c-aff7-8fe4d6d1dbd6'
$MSGRAPHAPI_tenantId = '98988d93-f1ee-41e8-8aea-ff73b005b87d'
$MSGRAPHAPI_Clientsecret = 'yourSecret'

$MSGRAPHAPI_BaseURL = "https://graph.microsoft.com/v1.0"




#Enter Azure App Details
$AzureAppName = "StatewidePermitsAPI"
$SecretDescription="ClientSecret"
$SecretDurationInMonth=24



#Auth MS Graph API and Get Header
$MSGRAPHAPI_tokenBody = @{  
    Grant_Type    = "client_credentials"  
    Scope         = "https://graph.microsoft.com/.default"  
    Client_Id     = $MSGRAPHAPI_clientID  
    Client_Secret = $MSGRAPHAPI_Clientsecret  
}   
$MSGRAPHAPI_tokenResponse = Invoke-RestMethod -Uri "https://login.microsoftonline.com/$MSGRAPHAPI_tenantId/oauth2/v2.0/token" -Method POST -Body $MSGRAPHAPI_tokenBody  
$MSGRAPHAPI_headers = @{
    "Authorization" = "Bearer $($MSGRAPHAPI_tokenResponse.access_token)"
    "Content-type"  = "application/json"
}





#Get Appi from App Name
$GetIDfromName_Params = @{
    Method = "GET"
    Uri    = "$MSGRAPHAPI_BaseURL/applications?`$filter=displayName eq '$AzureAppName'"
    header = $MSGRAPHAPI_headers
}        

$GetIDfromName_Result = Invoke-RestMethod @GetIDfromName_Params


#Add Secret to App
$AddSecretToAppReg_Body = @"
    {
        "passwordCredential": {
            "displayName": "$SecretDescription",
            "endDateTime": "$(Get-Date -format o (Get-Date).AddMonths($SecretDurationInMonth))"
        }
    }
"@

$AddSecretToAppReg_Params = @{
    Method = "POST"
    Uri    = "$MSGRAPHAPI_BaseURL/applications/$($GetIDfromName_Result.value.id)/addPassword"
    header = $MSGRAPHAPI_headers
    Body   = $AddSecretToAppReg_Body
}


$AddSecretToAppReg_Result = Invoke-RestMethod @AddSecretToAppReg_Params


#Secret
$AddSecretToAppReg_Result.secretText