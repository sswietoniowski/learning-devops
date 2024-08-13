helm upgrade --install greetings-dev ../Greetings `
  --create-namespace `
  --namespace greetings-dev `
  -f values-dev.yaml `
  --set helloApi.imageTag=1 `
  --set nameApi.imageTag=1
