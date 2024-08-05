### Don't run this script - it's just for reference ###

# List all contexts
kubectl config get-contexts

# Switch context
kubectl config use-context my-context

# Check current context
kubectl config current-context

# Create new context
kubectl config set-context my-context --cluster=<cluster-name> --user=<user-name> --namespace=<namespace>

# Set namespace for current context
kubectl config set-context --current --namespace=my-namespace
