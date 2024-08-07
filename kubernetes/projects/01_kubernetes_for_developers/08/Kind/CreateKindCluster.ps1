# Install the cluster and wait for it to be ready
kind create cluster --name k8s-course --config KindCluster.yaml --wait 90s

# Install Nginx Ingress Controller
kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/kind/deploy.yaml

# Wait for the Nginx Ingress Controller to be ready
kubectl wait --namespace ingress-nginx `
  --for=condition=ready pod `
  --selector=app.kubernetes.io/component=controller `
  --timeout=90s

Write-Output "Cluster is ready!"
