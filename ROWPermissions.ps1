$Gph = New-Object -TypeName "Microsoft.Open.AzureAD.Model.RequiredResourceAccess"
$Gph.ResourceAppId = "00000003-0000-0000-c000-000000000000"
$delPermission1 = New-Object -TypeName "Microsoft.Open.AzureAD.Model.ResourceAccess" -ArgumentList "df021288-bdef-4463-88db-98f22de89214","Role" ## Read all users' full profiles
 
$delPermission2 = New-Object -TypeName "Microsoft.Open.AzureAD.Model.ResourceAccess" -ArgumentList "b340eb25-3456-403f-be2f-af7a0d370277","Role" ## Read all users' basic profiles
 
$delPermission3 = New-Object -TypeName "Microsoft.Open.AzureAD.Model.ResourceAccess" -ArgumentList "741f803b-c850-494e-b5df-cde7c675a1ca","Role" ## Read and write all users' full profiles

$delPermission4 = New-Object -TypeName "Microsoft.Open.AzureAD.Model.ResourceAccess" -ArgumentList "e1fe6dd8-ba31-4d61-89e7-88639da4683d","Role" ## Sign in and read your profile

$Gph.ResourceAccess = $delPermission1, $delPermission2, $delPermission3, $delPermission4

$ADApplication = Get-AzureADApplication -All $true | ? { $_.AppId -match "c84561fa-1e13-444c-aff7-8fe4d6d1dbd6" }

Set-AzureADApplication -ObjectId $ADApplication.ObjectId -RequiredResourceAccess $Gph

