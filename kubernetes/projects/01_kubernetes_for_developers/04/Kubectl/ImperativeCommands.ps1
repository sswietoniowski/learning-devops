# This is an example of creating a namespace, deployment, and service
# imperatively. We'll cover better ways of doing this shortly in the
# course - we're just demoing this way for completeness.
kubectl create ns my-namespace
kubectl create deployment my-website --image=nginx --port=80 --replicas=3 --namespace my-namespace
kubectl expose deployment my-website --port=80 -n my-namespace

# Wait for the deployment to be ready
kubectl rollout status deployment/my-website

# Port forward to the service so we can access from our host
# (there are other ways - but we'll cover that later in this course)
kubectl port-forward service/my-website 8080:80 -n my-namespace

# If you want to cleanup, run this command after you're done...
# kubectl delete ns my-namespace
