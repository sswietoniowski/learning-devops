# Install the cluster and wait for it to be ready
kind create cluster --name k8s-course --config KindCluster.yaml --wait 90s

Write-Output "Cluster is ready!"
