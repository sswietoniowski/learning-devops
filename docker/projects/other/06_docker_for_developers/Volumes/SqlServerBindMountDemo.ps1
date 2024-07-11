docker rm -f nginx-withvol

docker run `
  --name nginx-withvol `
  -p 1234:80 `
  -v ${pwd}/html:/usr/share/nginx/html `
  nginx
