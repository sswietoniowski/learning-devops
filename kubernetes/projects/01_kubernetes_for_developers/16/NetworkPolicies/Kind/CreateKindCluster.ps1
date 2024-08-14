$startTime = Get-Date

# Install the cluster and wait for it to be ready
kind create cluster --name k8s-course --config KindCluster.yaml #--wait 90s

# Install network plugin that supports NetworkPolicy (https://docs.tigera.io/calico/latest/getting-started/kubernetes/kind)
kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.27.0/manifests/tigera-operator.yaml
kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.27.0/manifests/custom-resources.yaml

# Install Nginx Ingress Controller
kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/kind/deploy.yaml

# Wait for the Nginx Ingress Controller to be ready
Write-Output "Waiting for Nginx Ingress controller to be ready..."
kubectl wait --namespace ingress-nginx `
  --for=condition=ready pod `
  --selector=app.kubernetes.io/component=controller `
  --timeout=300s

$endTime = Get-Date
$duration = $endTime - $startTime

Write-Output "Cluster is ready! ($($duration.TotalSeconds) seconds)"
