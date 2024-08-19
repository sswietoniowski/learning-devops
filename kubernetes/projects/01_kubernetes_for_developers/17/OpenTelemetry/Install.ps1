helm repo add grafana https://grafana.github.io/helm-charts
helm repo add jaegertracing https://jaegertracing.github.io/helm-charts
helm repo add open-telemetry https://open-telemetry.github.io/opentelemetry-helm-charts
helm repo update

"#######################"
"## Installing Loki... #"
"#######################"

helm upgrade --install loki grafana/loki `
  --namespace telemetry `
  --create-namespace `
  -f $PSScriptRoot\values-loki.yaml

"#########################"
"## Installing Jaeger... #"
"#########################"

helm upgrade --install jaeger jaegertracing/jaeger `
  --namespace telemetry `
  --create-namespace `
  -f $PSScriptRoot\values-jaeger.yaml

kubectl apply -f jaeger-service.yaml

"################################"
"## Installing OTel Operator... #"
"################################"
# Docs: https://github.com/open-telemetry/opentelemetry-helm-charts/tree/main/charts/opentelemetry-operator

helm install --namespace telemetry `
  opentelemetry-operator open-telemetry/opentelemetry-operator `
  -f $PSScriptRoot\values-oteloperator.yaml

"################################"
"## Installing OTel Collector...#"
"################################"

kubectl apply -f Collector.yaml
