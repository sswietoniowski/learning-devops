$cert = ""

[System.Text.Encoding]::UTF8.GetString([Convert]::FromBase64String($cert)) `
  > kind-user.crt

openssl x509 -in kind-user.crt -noout -text

del kind-user.crt
