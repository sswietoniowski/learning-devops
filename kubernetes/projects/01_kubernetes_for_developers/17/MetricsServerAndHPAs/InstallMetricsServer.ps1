kubectl apply -f https://github.com/kubernetes-sigs/metrics-server/releases/latest/download/components.yaml

# Required if using KinD
# Source/credit: https://gist.github.com/sanketsudake/a089e691286bf2189bfedf295222bd43?permalink_comment_id=3914458#gistcomment-3914458
kubectl patch -n kube-system deployment metrics-server --type=json `
  -p '[{"op":"add","path":"/spec/template/spec/containers/0/args/-","value":"--kubelet-insecure-tls"}]'
