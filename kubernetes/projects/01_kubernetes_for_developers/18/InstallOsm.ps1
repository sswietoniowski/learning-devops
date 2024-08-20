osm install `
    --mesh-name "osm" `
    --osm-namespace "osm-system" `
    --set=osm.enablePermissiveTrafficPolicy=true `
    --set=osm.deployPrometheus=true `
    --set=osm.deployGrafana=true `
    --set=osm.deployJaeger=true
