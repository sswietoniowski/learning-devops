kubectl apply -f Namespace.yaml
osm namespace add demo-apis
osm metrics enable --namespace demo-apis

osm namespace add "ingress-nginx" --mesh-name "osm" --disable-sidecar-injection

kubectl apply `
  -f HelloApi.yaml `
  -f NameApi.yaml
