# Kubernates in 4 Hours

General introduction to Kubernates.

## Table of Contents

- [Kubernates in 4 Hours](#kubernates-in-4-hours)
  - [Table of Contents](#table-of-contents)
  - [What is Kubernetes?](#what-is-kubernetes)
  - [What are Containers?](#what-are-containers)
  - [Container needs in Datacenter and Cloud](#container-needs-in-datacenter-and-cloud)
  - [About the Kubernetes Host Platform](#about-the-kubernetes-host-platform)
  - [CNCF: Standardization on K8s](#cncf-standardization-on-k8s)
  - [Kubernetes and the Ecosystem](#kubernetes-and-the-ecosystem)
  - [Kubernetes Distributions](#kubernetes-distributions)
  - [Kubernetes Usage Options](#kubernetes-usage-options)
  - [Minikube Overview](#minikube-overview)
  - [Installing Minikube](#installing-minikube)
  - [Running Your First Application](#running-your-first-application)
  - [Managing Kubernetes](#managing-kubernetes)
  - [Using kubectl](#using-kubectl)
  - [Understanding Main Kubernetes Resource Types](#understanding-main-kubernetes-resource-types)
  - [Understanding the Pod](#understanding-the-pod)
  - [Understanding the Deployment](#understanding-the-deployment)
  - [Managing applications with kubectl](#managing-applications-with-kubectl)
  - [Using kubectl in a declarative way](#using-kubectl-in-a-declarative-way)
  - [Creating YAML Files](#creating-yaml-files)
  - [Understanding Namespaces](#understanding-namespaces)
  - [Troubleshooting Kubernetes Applications](#troubleshooting-kubernetes-applications)
  - [Demo: Troubleshooting Applications](#demo-troubleshooting-applications)
  - [Understanding Pod Access](#understanding-pod-access)
  - [Understanding Ingress](#understanding-ingress)
  - [Understanding Service Types](#understanding-service-types)
  - [Demo: Using Services - 1](#demo-using-services---1)
  - [Demo: Using Services - 2](#demo-using-services---2)
  - [Understanding Container Storage](#understanding-container-storage)
  - [Demo](#demo)
  - [Understanding ConfigMaps](#understanding-configmaps)
  - [Creating ConfigMaps - Overview](#creating-configmaps---overview)
  - [Demo: Creating ConfigMaps for Variables](#demo-creating-configmaps-for-variables)

## What is Kubernetes?

- Kubernetes is a platform for running container-based cloud-native
  applications
- It offers different resources that allow for storing information in the
  cloud instead of on a local host
- It offers enterprise features like scalability and availability
- It orchestrates containers in such a way that they are providing the
  services that are required in the environment where these services
  are required
- The solution is based on the Borg technology that Google has been
  using for many years in their datacenters

## What are Containers?

- A container image includes all dependencies required to run an
  application
- Containers are running instances of container images
- To run a container, a container engine is required. Container
  engines run on top of a host operating system
- Docker and Podmanare common solutions for running containers
  on stand-alone computers
- Kubernetes adds cluster features to containers by managing them
  in pod resources

## Container needs in Datacenter and Cloud

- Storage that is not bound to any specific physical environment
- A cluster of hosts to run the containers
- Monitoring and self-healing of containers
- A solution for updates without downtime
- A flexible network that can self-extend if that is needed

## About the Kubernetes Host Platform

Kubernetes can be offered through different host platforms

- As a hosted service in public cloud
- On top of a physical cluster (on premise)
- As an all-in-one solution, running on Minikube

## CNCF: Standardization on K8s

- Cloud Native Computing Foundation (CNCF) is a governing body
  that solves issues faced by any cloud native application (so not just
  Kubernetes)
- Google donated Kubernetes to the Cloud Native Computing
  Foundation, which is a foundation in Linux Foundation
- CNCF owns the copyright of Kubernetes

## Kubernetes and the Ecosystem

- CNCF hosts many cloud native projects and Kubernetes is just one
  of them
- In Kubernetes installations, other CNCF projects are included:
  - Network Plugins
  - Storage Provisioners
  - Ingress and more
- Distributions bundle Kubernetes with other CNCF projects to get a
  completely working environment

## Kubernetes Distributions

- Kubernetes is the open-source standard for orchestrating
  containers, competing products include - Amazon ECS - Docker Swarm - Apache Nomad - Amazon Fargate
- Common Kubernetes distributions include
  - Rancher
  - Red Hat OpenShift
  - Google Anthos
  - Public cloud distributions like EKS, AKS and GKS

Kubernetes in 4 Hours

## Kubernetes Usage Options

- There are many options
  - Minikube
  - Cloud based
  - Docker Desktop
  - O'Reilly Sandbox
- Demo'ing in this course: minikube

## Minikube Overview

- Minikubeoffers a complete test environment that runs on Linux,
  MacOS or Windows
- Other test environments can also be used
- In all cases, you'll need to have the **kubectl** client on your
  management platform

## Installing Minikube

- A scripted installation is provided for Ubuntu 20.04 and later
- Install either of these with at least 4 GB RAM and 20 GB disk space
  (8 GB and 40GB recommended)
- Use **git clone https://github.com/sandervanvugt/kubernetes**
- From there, use the **minikube-docker-setup.sh** script and follow
  instructions

## Running Your First Application

- From **minikubedashboard** , click +CREATE in the upper right corner
- Specify **httpd** as the container image as well as the container name
- This will pull the container image and run it in the minikube
  environment

## Managing Kubernetes

- The **kubectl** command line utility provides convenient
  administrator access, allowing you to run many tasks against the
  cluster
- Direct API access allows developers to address the cluster using API
  calls from custom scripts
- The Kubernetes Console offers a web based interface

## Using kubectl

- The **kubectl** command is the generic command that allows you to
  manage all aspects of pods and containers
- Use **kubectlcreate** to create deployment
- Or **kubectlget ...** or one of the many other options to get
  information about pods
- Start with **kubectlcompletion -h**

## Understanding Main Kubernetes Resource Types

- _Pods_ : the basic unit in Kubernetes, represents one or more
  containers that share common resources
- _Deployments_ : the application itself, standard entity that is rolled out
  with Kubernetes
- _Services_ : make deployments accessible from the outside by
  providing a single IP/port combination.
- _Persistent Volumes_ : persistent (networked) storage
- _ConfigMaps_ : Allow for storing configuration and other specific
  parameters in a cloud environment

## Understanding the Pod

- Kubernetes manages Pods, not containers
- The Pod is a Kubernetes resource, defined in the Kubernetes API to
  provide features required for managing containers in a clustered
  environment
- Containers can be put together in a Pod, together with Pod-specific
  storage, but a typical pod runs one container only

## Understanding the Deployment

- To run applications in Kubernetes, create deployments
- A deployment is adding scalability as well as zero-downtime
  upgrades to Pods
- Do **NOT** run standalone Pods, run deployments only

## Managing applications with kubectl

- Use **kubectlcreate deploy ...** to run an application
  - **kubectlcreate deploy mynginx--image=nginx--replicas=3**
- Use **kubectlget** to get information about running applications
  - **kubectlget all**
  - **kubectlget pods**
  - **kubectlget all --selector app=mynginx**
- Use **kubectldescribe** to get information about resource properties
  - **kubectldescribe pod mynginx-aaa-bbb**

## Using kubectl in a declarative way

- To work with Kubernetes the DevOps way, you should define the
  desired configuration in a YAML manifest file
- This _declarative_ methodology is giving you much more control than
  the _imperative_ methodology where you create all from the CLI - Get current state of an object: **kubectlget deployments nginx-o yaml** - Push settings from a new manifest: **kubectlcreate -f nginx.yaml** - Apply settings from a manifest: **kubectlapply -f nginx.yaml**

## Creating YAML Files

- YAML files are used in declarative way
- Don't write them from scratch, generate them
- Use **kubectl create deploy mynginx --image=nginx --dry-run=client**
  **- o yaml > mypod.yaml** to easily generate a YAML file
- Use **kubectl explain** for more information about properties to be
  used in the YAML files
- Consult kubernetes.io/docs for many examples!

## Understanding Namespaces

- Namespaces create isolated environments for running applications
- Use namespaces to create virtual datacenters
- Kubernetes core services run in the **kube-system** namespace
- Role Based Access Control (RBAC) can be used to delegate
  administrator / user privileges to a namespace
- Quota can be used to restrict resources in a namespace

## Troubleshooting Kubernetes Applications

- **kubectldescribe pod ...** is showing cluster information about Pods
  and should be the first thing to troubleshoot Kubernetes workloads
- **kubectllogs** is giving access to the Pod application STDOUT, which
  allows you to see what is going on in an application
- **kubectlget pods podname-o yaml** shows detailed information
  about what is going on in a Pod
- **kubectlexec -it PODNAME --/bin/sh** gives access to a shell running
  within a Pod

## Demo: Troubleshooting Applications

- **kubectl create deploy mydb --image=mariadb --replicas=3**
- **kubectl describe pod mydb-aaa-bbb**
- **kubectl logs mydb-aaa-bbb**
- **kubectl set env deploy/mydb MARIADB_ROOT_PASSWORD=secret**

## Understanding Pod Access

- Pods are connected to the pod network. The pod network is behind
  the firewall, and its addresses cannot be directly accessed
- As typically multiple instances of pods are started, a load balancer is
  needed to connect incoming user requests to a specific pod
- This API-based load balancing functionality is offered by the _Service_
  resource
- The service provides one single IP-address that should be addressed
  to connect to a specific pod

## Understanding Ingress

- _Ingress_ is an additional resource, that provides external access to
  HTTP and HTTPS based services
- _Ingress_ also defines a virtual service name to provide easy access to
  services
- Different Ingress solutions are provided by the Kubernetes
  ecosystem

## Understanding Service Types

- **ClusterIP** is accessible from within the cluster only
- **NodePort** exposes an external port on the cluster nodes, thus
  providing a primitive way for offering access to the services
- _Ingress_ is what should be used to provide user-friendly access to
  services

## Demo: Using Services - 1

- **kubectl create deployment nginxsvc --image=nginx**
- **kubectl scale deployment nginxsvc --replicas=3**
- **kubectl expose deployment nginxsvc --port=80**
- **kubectl describe svc nginxsvc** # look for endpoints
- **kubectl get svc**
- **kubectl get endpoints**

## Demo: Using Services - 2

- **minikube ssh**
- **curl [http://svc-ip-address](http://svc-ip-address)**
- **exit**
- **kubectl edit svc nginxsvc**
  **...**
  **protocol: TCP**
  **nodePort: 32000
  type: NodePort**
- **kubectl get svc**
- (from host): **curl [http://$(minikube](http://$(minikube) ip):32000**

## Understanding Container Storage

- Container storage by nature is ephemeral
- To provide persistent storage, the Pod specification can define
  containers as well as volumes
- The pod volumes can be used to refer to any type of storage
- Use **kubectl explain pod.spec.volumes** to see which volume types
  are supported

## Demo

1. **kubectlcreate -f morevolumes.yaml**
2. **kubectlget pods morevol2**
3. **kubectldescribe pods morevol2 | less** ## verify there are
   two containers in the pod
4. **kubectlexec -timorevol2 -c centos1 --touch /centos1/test**
5. **kubectlexec -timorevol2 -c centos2 --ls -l /centos2**

## Understanding ConfigMaps

- In a cloud-native environment, a solution must be provided to store
  site-specific data
- Storing configuration files, variables and startup parameters inside
  the pod specification would make it less portable
- ConfigMapsallow for storing site-specific information in dedicated
  API resources
- By storing site-specific information in ConfigMaps, you can keep the
  Pod and Deployment specifications generic
- ConfigMapsare commonly used for storing variables and
  Configuration Files
- Secrets are base64 encoded ConfigMaps

## Creating ConfigMaps - Overview

- Start by defining the ConfigMap and create it
  - Consider the different sources that can be used for ConfigMaps
  - kubectlcreate cm myconf--from-file=my.conf
  - kubectlcreate cm variables --from-env-file=variables
  - kubectlcreate cm special --from-literal=VAR3=cow --from-
    literal=VAR4=goat
  - Verify creation, using kubectldescribe cm <cmname>
- Use --from-fileto put the contents of a config file in the configmap
- Use --from-env-file to define variables
- Use --from-literal to define variables or command line

## Demo: Creating ConfigMaps for Variables

- Create a deployment: **kubectlcreate deploy mynewdb--**
  **image=mysql--replicas=3**
- Use **kubectlget pods --selector app=mynewdb** to see that the pods
  in the new deployment are failing
- Create a ConfigMap: **kubectlcreate cm mynewdbvars--from-**
  **literal=MYSQL_ROOT_PASSWORD=password**
- Check the contents of the ConfigMap: **kubectldescribe cm**
  **mynewdbvars**
- Apply it: **kubectlset env --from=configmap/mynewdbvars**
  **deploy/mynewdb**
- Use **kubectlget all --selector app=mynewdb** to see what is
  happening
