helm upgrade --install greetings-prod ../Greetings `
  --create-namespace `
  --namespace greetings-prod `
  -f values-prod.yaml `
  --set helloApi.imageTag=1 `
  --set nameApi.imageTag=1
