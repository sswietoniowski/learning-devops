# Copy CA certificate and key from control plane to local machine
docker cp k8s-course-control-plane:/etc/kubernetes/pki/ca.crt .
docker cp k8s-course-control-plane:/etc/kubernetes/pki/ca.key .

# Generate user certificate and key
openssl genrsa -out bob.key 2048
openssl req -new -key bob.key -out bob.csr -subj "/CN=bob/O=tenant1"

openssl x509 -req -in bob.csr -CA ca.crt -CAkey ca.key -CAcreateserial -out bob.crt -days 360

$crt = [Convert]::ToBase64String([IO.File]::ReadAllBytes((Join-Path -Path $PSScriptRoot -ChildPath "bob.crt")))
$key = [Convert]::ToBase64String([IO.File]::ReadAllBytes((Join-Path -Path $PSScriptRoot -ChildPath "bob.key")))

"CRT = $crt"
"KEY = $key"

# Cleanup
Remove-Item -Path ca.crt, ca.key, bob.crt, bob.csr, bob.key, ca.srl -Force
