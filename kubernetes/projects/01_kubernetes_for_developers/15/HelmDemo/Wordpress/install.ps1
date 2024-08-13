# helm repo add bitnami https://charts.bitnami.com/bitnami
helm upgrade --install my-wordpress bitnami/wordpress --version 19.2.4 -f values.yaml
