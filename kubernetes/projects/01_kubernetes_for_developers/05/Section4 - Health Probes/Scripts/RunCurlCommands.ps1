kubectl run curl-pod --rm --restart=Never -i --tty --image=curlimages/curl -n health-check-demo `
  -- sh -c 'for i in $(seq 1 10); do
    curl http://my-service; echo;
  done'
