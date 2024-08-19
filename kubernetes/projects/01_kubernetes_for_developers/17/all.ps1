# This script will install the entire demo in one go from scratch into a brand new cluster

Set-location Kind
./DeleteKindCluster.ps1
./CreateKindCluster.ps1
Set-Location ..

Set-Location PrometheusStack
./InstallPromStack.ps1
Set-Location ..

Set-Location OpenTelemetry
./Install.ps1
Set-Location Api/Yaml
./apply.ps1
Set-Location ../../..
