# Install the Dashboard
kubectl apply -f https://raw.githubusercontent.com/kubernetes/dashboard/v2.7.0/aio/deploy/recommended.yaml

# Apply service account and cluster role binding
kubectl apply -f auth.yaml

# Create a token for the admin user (and output it)
kubectl -n kubernetes-dashboard create token admin-user

# Note that the above token is only valid for an hour - which is fine for our demo.
# You can create a longer lived one easily by creating a Kubernetes secret object that
# will contain a longer lived token. Details are here:
#
# https://github.com/kubernetes/dashboard/blob/master/docs/user/access-control/creating-sample-user.md#getting-a-long-lived-bearer-token-for-serviceaccount
