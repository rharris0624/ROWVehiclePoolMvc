$appName = "StatewidePermitsMvcCore"
$appURI = "https://ashtd.onmicrosoft.com/StatewidePermitsMvcCore"
$appHomePageUrl = "https://localhost:7169/"
$appReplyURLs = @($appURI, $appHomePageURL, "https://localhost:7214/Signin-oidc")
if(!($myApp = Get-AzureADApplication -Filter "DisplayName eq '$($appName)'"  -ErrorAction SilentlyContinue))
{
    $myApp = New-AzureADApplication -DisplayName $appName -IdentifierUris $appURI -Homepage $appHomePageUrl -ReplyUrls $appReplyURLs    
}

//Add App Key
$Guid = New-Guid
$startDate = Get-Date
    
$PasswordCredential = New-Object -TypeName Microsoft.Open.AzureAD.Model.PasswordCredential
$PasswordCredential.StartDate = $startDate
$PasswordCredential.EndDate = $startDate.AddYears(1)
$PasswordCredential.KeyId = $Guid
$PasswordCredential.Value = ([System.Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes(($Guid))))