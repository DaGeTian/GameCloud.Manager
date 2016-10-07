Param(
	[string]$resourceGroupName,
	[string]$webAppName,
	[string]$slotName = "production"
)

$webApp = Get-AzureRMWebAppSlot -ResourceGroupName $resourceGroupName -Name $webAppName -Slot $slotName
$appSettingList = $webApp.SiteConfig.AppSettings
$hash = @{}
ForEach ($kvp in $appSettingList) {
    $hash[$kvp.Name] = $kvp.Value
}
$hash["AppSettings:BuildVersion"] = "$Env:BUILD_BUILDNUMBER"
Set-AzureRMWebAppSlot -ResourceGroupName $resourceGroupName -Name $webAppName -AppSettings $hash -Slot $slotName
Write-Host "Done!"