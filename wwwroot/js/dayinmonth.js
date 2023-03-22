function getNoOfDaysInMnth(mnth,yr) {
 
 var rem = yr % 4;
 var cent = yr % 100;
 if (rem == 0) {
    if (cent == 0)
        leap = 0;
    else
        leap = 1;
 } else {
  leap = 0;
 }

 noDays=0;

 if ( (mnth == 1) || (mnth == 3) || (mnth == 5) ||
      (mnth == 7) || (mnth == 8) || (mnth == 10) ||
      (mnth == 12)) 
 {
  noDays=31;
 }
 else if (mnth == 2)
 {
       noDays=28+leap;
 } 
	   else
	   {
           noDays=30;
       }

 //alert(noDays);
 return noDays;
 
      
}
