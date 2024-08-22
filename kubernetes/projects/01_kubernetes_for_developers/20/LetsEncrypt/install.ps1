# Install Cert Manager
kubectl apply -f https://github.com/cert-manager/cert-manager/releases/download/v1.13.4/cert-manager.yaml

# Wait for the deployments to be ready
kubectl rollout status -n cert-manager deployment/cert-manager
kubectl rollout status -n cert-manager deployment/cert-manager-cainjector
kubectl rollout status -n cert-manager deployment/cert-manager-webhook

# Apply the ClusterIssuer
kubectl apply -f ClusterIssuer.yaml

# Install our YAML

# IMPORTANT! This will not fully succeed locally, as it requires LetsEncrypt to be able
# to access our cluster. In a deployed environment, once you set up the DNS records for
# your domain name where the domain points to your ingress controller's service's IP
# address, it'll all automagically work! For this demo, we'll see the certificate request
# and a pending certificate being created.

kubectl apply `
  -f Yaml/Namespace.yaml `
  -f Yaml/HelloApi.yaml `
  -f Yaml/NameApi.yaml
