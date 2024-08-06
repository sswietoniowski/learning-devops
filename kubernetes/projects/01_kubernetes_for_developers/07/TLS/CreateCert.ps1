openssl req `
  -newkey rsa:2048 `
  -nodes `
  -x509 `
  -days 365 `
  -out selfsigned.crt `
  -keyout selfsigned.key `
  -subj "/CN=my-domain.com" `
  -addext "subjectAltName = DNS:my-domain.com"

kubectl apply -f ../Yaml-TlsExample/Namespace.yaml

kubectl create secret tls mydomain-tls `
  --cert=selfsigned.crt `
  --key=selfsigned.key `
  -n services-demo
