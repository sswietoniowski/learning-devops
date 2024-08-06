kubectl run curl-pod --rm --restart=Never -i --tty --image=curlimages/curl -n health-check-demo `
  -- sh -c 'curl -X POST -w "\nHTTP Status Code: %{http_code}\n" -H "Content-Type: application/json" \
  -d ''{
    "fakeLivenessFault": true,
    "fakeReadinessFault": false,
    "fakeStartupFault": false
  }'' http://my-service/faults; echo;'
