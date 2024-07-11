"Delete volume if it already exists..."
docker volume rm BackupDemoVolume

"Create volume..."
docker volume create BackupDemoVolume

"Write file to our volume..."
docker run `
  -it `
  -v BackupDemoVolume:/mydata `
  alpine `
  sh -c "echo 'Hello' > /mydata/hello.txt"

"Create backup of volume..."
docker run `
  --rm `
  -v BackupDemoVolume:/mydata `
  -v ${pwd}:/backup `
  alpine `
  sh -c "cd /mydata && tar cvf /backup/backup.tar *"

"Restore backup..."
docker run `
  --rm `
  -v RestoredVolume:/mydata `
  -v ${pwd}:/backup alpine sh `
  -c "cd /mydata && tar xvf /backup/backup.tar"
