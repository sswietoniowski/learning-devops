# Kubernates in 4 Hours

General introduction to Kubernates.

## Table of Contents

- [Kubernates in 4 Hours](#kubernates-in-4-hours)
  - [Table of Contents](#table-of-contents)
  - [Agenda](#agenda)
- [Click to edit Master title style](#click-to-edit-master-title-style)
- [Expectations](#expectations)
  - [Click to edit Master title style](#click-to-edit-master-title-style-1)
- [Click to edit Master title style](#click-to-edit-master-title-style-2)
- [Poll question 4](#poll-question-4)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours)
  - [What is Kubernetes?](#what-is-kubernetes)
- [Click to edit Master title style](#click-to-edit-master-title-style-3)
- [What is Kubernetes?](#what-is-kubernetes-1)
- [Click to edit Master title style](#click-to-edit-master-title-style-4)
- [What are Containers?](#what-are-containers)
- [Click to edit Master title style](#click-to-edit-master-title-style-5)
  - [Container needs in Datacenter and Cloud](#container-needs-in-datacenter-and-cloud)
- [Click to edit Master title style](#click-to-edit-master-title-style-6)
- [About the Kubernetes Host Platform](#about-the-kubernetes-host-platform)
- [Click to edit Master title style](#click-to-edit-master-title-style-7)
- [CNCF: Standardization on K8s](#cncf-standardization-on-k8s)
- [Click to edit Master title style](#click-to-edit-master-title-style-8)
- [Kubernetes and the Ecosystem](#kubernetes-and-the-ecosystem)
- [Click to edit Master title style](#click-to-edit-master-title-style-9)
- [Kubernetes Distributions](#kubernetes-distributions)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-1)
  - [Installing a Kubernetes Test](#installing-a-kubernetes-test)
  - [Cluster](#cluster)
- [Click to edit Master title style](#click-to-edit-master-title-style-10)
- [Kubernetes Usage Options](#kubernetes-usage-options)
- [Click to edit Master title style](#click-to-edit-master-title-style-11)
- [Minikube Overview](#minikube-overview)
- [Click to edit Master title style](#click-to-edit-master-title-style-12)
- [Installing Minikube](#installing-minikube)
- [Click to edit Master title style](#click-to-edit-master-title-style-13)
- [Running Your First Application](#running-your-first-application)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-2)
  - [Accessing and Using the](#accessing-and-using-the)
  - [Cluster](#cluster-1)
- [Click to edit Master title style](#click-to-edit-master-title-style-14)
- [Managing Kubernetes](#managing-kubernetes)
- [Click to edit Master title style](#click-to-edit-master-title-style-15)
- [Using kubectl](#using-kubectl)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-3)
  - [Understanding Kubernetes](#understanding-kubernetes)
  - [Resource Types](#resource-types)
- [Click to edit Master title style](#click-to-edit-master-title-style-16)
  - [Understanding Main Kubernetes Resource Types](#understanding-main-kubernetes-resource-types)
- [Click to edit Master title style](#click-to-edit-master-title-style-17)
- [Understanding the Pod](#understanding-the-pod)
- [Click to edit Master title style](#click-to-edit-master-title-style-18)
- [Understanding the Deployment](#understanding-the-deployment)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-4)
  - [Managing Applications with](#managing-applications-with)
  - [kubectl](#kubectl)
- [Click to edit Master title style](#click-to-edit-master-title-style-19)
- [Managing applications with kubectl](#managing-applications-with-kubectl)
- [Click to edit Master title style](#click-to-edit-master-title-style-20)
- [Using kubectl in a declarative way](#using-kubectl-in-a-declarative-way)
- [Click to edit Master title style](#click-to-edit-master-title-style-21)
- [Creating YAML Files](#creating-yaml-files)
- [Click to edit Master title style](#click-to-edit-master-title-style-22)
- [Understanding Namespaces](#understanding-namespaces)
- [Click to edit Master title style](#click-to-edit-master-title-style-23)
  - [Troubleshooting Kubernetes Applications](#troubleshooting-kubernetes-applications)
- [Click to edit Master title style](#click-to-edit-master-title-style-24)
- [Demo: Troubleshooting Applications](#demo-troubleshooting-applications)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-5)
  - [Accessing applications from](#accessing-applications-from)
  - [Outside](#outside)
- [Click to edit Master title style](#click-to-edit-master-title-style-25)
- [Understanding Pod Access](#understanding-pod-access)
- [Click to edit Master title style](#click-to-edit-master-title-style-26)
- [Understanding Ingress](#understanding-ingress)
- [Click to edit Master title style](#click-to-edit-master-title-style-27)
- [Understanding Service Types](#understanding-service-types)
- [Click to edit Master title style](#click-to-edit-master-title-style-28)
- [Demo: Using Services - 1](#demo-using-services---1)
- [Click to edit Master title style](#click-to-edit-master-title-style-29)
- [Demo: Using Services - 2](#demo-using-services---2)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-6)
  - [Working with Storage](#working-with-storage)
- [Click to edit Master title style](#click-to-edit-master-title-style-30)
- [Understanding Container Storage](#understanding-container-storage)
- [Click to edit Master title style](#click-to-edit-master-title-style-31)
- [Demo](#demo)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-7)
  - [Using ConfigMaps](#using-configmaps)
- [Click to edit Master title style](#click-to-edit-master-title-style-32)
- [Understanding ConfigMaps](#understanding-configmaps)
- [Click to edit Master title style](#click-to-edit-master-title-style-33)
- [Creating ConfigMaps - Overview](#creating-configmaps---overview)
- [Click to edit Master title style](#click-to-edit-master-title-style-34)
  - [Demo: Creating ConfigMaps for Variables](#demo-creating-configmaps-for-variables)
- [Click to edit Master title styleKubernetes in 4 Hours](#click-to-edit-master-title-stylekubernetes-in-4-hours-8)
  - [Summary](#summary)
- [Click to edit Master title style](#click-to-edit-master-title-style-35)
- [Next Steps](#next-steps)

## Agenda

- Understanding Kubernetes
- Kubernetes Installation and Configuration
- Running Applications in Pods and Containers
- Exposing Applications using Services
- Using Volumes to Provide Storage
- Using ConfigMapsto decouple site specific information from code

# Click to edit Master title style

# Expectations

- This class is for people new to Kubernetes
- I'll teach you how to get started and deploy applications on
  Kubernetes
- Don't expect much information about advanced topics
- For more in-depth information consider one of the following classes
  - CKAD is a 3 days class that prepares for the CKAD exam
  - Kubernetes in 3 weeks covers all important concepts in a 3 weeks
    program
  - Managing Microservices with Kubernetes and Istio is a 5 hours class in
    which you'll learn how to use Kubernetes to build Microservices
  - GitOpsand Kubernetes Automation in 3 Weeks explains how to use
    GitOpsto work with Kubernetes more efficiently

## Click to edit Master title style

- Poll question
  - • • How would you rate your knowledge about containers
  - •
  - •
  - •
  - •
  - •
- Poll question Click to edit Master title style
  - • • How would you rate your Kubernetes knowledge and experience?
  - •
  - •
  - •
  - •
  - •

# Click to edit Master title style

# Poll question 4

- Where are you from?
  - India
  - Asia (other countries)
  - Africa
  - North or Central America
  - South America
  - Europe
  - Australia / Pacific
  - Netherlands

# Click to edit Master title styleKubernetes in 4 Hours

## What is Kubernetes?

# Click to edit Master title style

# What is Kubernetes?

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

# Click to edit Master title style

# What are Containers?

- A container image includes all dependencies required to run an
  application
- Containers are running instances of container images
- To run a container, a container engine is required. Container
  engines run on top of a host operating system
- Docker and Podmanare common solutions for running containers
  on stand-alone computers
- Kubernetes adds cluster features to containers by managing them
  in pod resources

# Click to edit Master title style

## Container needs in Datacenter and Cloud

- Storage that is not bound to any specific physical environment
- A cluster of hosts to run the containers
- Monitoring and self-healing of containers
- A solution for updates without downtime
- A flexible network that can self-extend if that is needed

# Click to edit Master title style

# About the Kubernetes Host Platform

```
Kubernetes can be offered through different host platforms
```

- As a hosted service in public cloud
- On top of a physical cluster (on premise)
- As an all-in-one solution, running on Minikube

# Click to edit Master title style

# CNCF: Standardization on K8s

- Cloud Native Computing Foundation (CNCF) is a governing body
  that solves issues faced by any cloud native application (so not just
  Kubernetes)
- Google donated Kubernetes to the Cloud Native Computing
  Foundation, which is a foundation in Linux Foundation
- CNCF owns the copyright of Kubernetes

# Click to edit Master title style

# Kubernetes and the Ecosystem

- CNCF hosts many cloud native projects and Kubernetes is just one
  of them
- In Kubernetes installations, other CNCF projects are included:
  - Network Plugins
  - Storage Provisioners
  - Ingress and more
- Distributions bundle Kubernetes with other CNCF projects to get a
  completely working environment

# Click to edit Master title style

# Kubernetes Distributions

- Kubernetes is the open-source standard for orchestrating
  containers, competing products include - Amazon ECS - Docker Swarm - Apache Nomad - Amazon Fargate
- Common Kubernetes distributions include
  - Rancher
  - Red Hat OpenShift
  - Google Anthos
  - Public cloud distributions like EKS, AKS and GKS

# Click to edit Master title styleKubernetes in 4 Hours

## Installing a Kubernetes Test

## Cluster

# Click to edit Master title style

# Kubernetes Usage Options

- There are many options
  - Minikube
  - Cloud based
  - Docker Desktop
  - O'Reilly Sandbox
- Demo'ing in this course: minikube

# Click to edit Master title style

# Minikube Overview

- Minikubeoffers a complete test environment that runs on Linux,
  MacOS or Windows
- Other test environments can also be used
- In all cases, you'll need to have the **kubectl** client on your
  management platform

# Click to edit Master title style

# Installing Minikube

- A scripted installation is provided for Ubuntu 20.04 and later
- Install either of these with at least 4 GB RAM and 20 GB disk space
  (8 GB and 40GB recommended)
- Use **git clone https://github.com/sandervanvugt/kubernetes**
- From there, use the **minikube-docker-setup.sh** script and follow
  instructions

# Click to edit Master title style

# Running Your First Application

- From **minikubedashboard** , click +CREATE in the upper right corner
- Specify **httpd** as the container image as well as the container name
- This will pull the container image and run it in the minikube
  environment

# Click to edit Master title styleKubernetes in 4 Hours

## Accessing and Using the

## Cluster

# Click to edit Master title style

# Managing Kubernetes

- The **kubectl** command line utility provides convenient
  administrator access, allowing you to run many tasks against the
  cluster
- Direct API access allows developers to address the cluster using API
  calls from custom scripts
- The Kubernetes Console offers a web based interface

# Click to edit Master title style

# Using kubectl

- The **kubectl** command is the generic command that allows you to
  manage all aspects of pods and containers
- Use **kubectlcreate** to create deployment
- Or **kubectlget ...** or one of the many other options to get
  information about pods
- Start with **kubectlcompletion -h**

# Click to edit Master title styleKubernetes in 4 Hours

## Understanding Kubernetes

## Resource Types

# Click to edit Master title style

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

# Click to edit Master title style

# Understanding the Pod

- Kubernetes manages Pods, not containers
- The Pod is a Kubernetes resource, defined in the Kubernetes API to
  provide features required for managing containers in a clustered
  environment
- Containers can be put together in a Pod, together with Pod-specific
  storage, but a typical pod runs one container only

# Click to edit Master title style

# Understanding the Deployment

- To run applications in Kubernetes, create deployments
- A deployment is adding scalability as well as zero-downtime
  upgrades to Pods
- Do **NOT** run standalone Pods, run deployments only

# Click to edit Master title styleKubernetes in 4 Hours

## Managing Applications with

## kubectl

# Click to edit Master title style

# Managing applications with kubectl

- Use **kubectlcreate deploy ...** to run an application
  - **kubectlcreate deploy mynginx--image=nginx--replicas=3**
- Use **kubectlget** to get information about running applications
  - **kubectlget all**
  - **kubectlget pods**
  - **kubectlget all --selector app=mynginx**
- Use **kubectldescribe** to get information about resource properties
  - **kubectldescribe pod mynginx-aaa-bbb**

# Click to edit Master title style

# Using kubectl in a declarative way

- To work with Kubernetes the DevOps way, you should define the
  desired configuration in a YAML manifest file
- This _declarative_ methodology is giving you much more control than
  the _imperative_ methodology where you create all from the CLI - Get current state of an object: **kubectlget deployments nginx-o yaml** - Push settings from a new manifest: **kubectlcreate -f nginx.yaml** - Apply settings from a manifest: **kubectlapply -f nginx.yaml**

# Click to edit Master title style

# Creating YAML Files

- YAML files are used in declarative way
- Don't write them from scratch, generate them
- Use **kubectl create deploy mynginx --image=nginx --dry-run=client**
  **- o yaml > mypod.yaml** to easily generate a YAML file
- Use **kubectl explain** for more information about properties to be
  used in the YAML files
- Consult kubernetes.io/docs for many examples!

# Click to edit Master title style

# Understanding Namespaces

- Namespaces create isolated environments for running applications
- Use namespaces to create virtual datacenters
- Kubernetes core services run in the **kube-system** namespace
- Role Based Access Control (RBAC) can be used to delegate
  administrator / user privileges to a namespace
- Quota can be used to restrict resources in a namespace

# Click to edit Master title style

## Troubleshooting Kubernetes Applications

- **kubectldescribe pod ...** is showing cluster information about Pods
  and should be the first thing to troubleshoot Kubernetes workloads
- **kubectllogs** is giving access to the Pod application STDOUT, which
  allows you to see what is going on in an application
- **kubectlget pods podname-o yaml** shows detailed information
  about what is going on in a Pod
- **kubectlexec -it PODNAME --/bin/sh** gives access to a shell running
  within a Pod

# Click to edit Master title style

# Demo: Troubleshooting Applications

- **kubectl create deploy mydb --image=mariadb --replicas=3**
- **kubectl describe pod mydb-aaa-bbb**
- **kubectl logs mydb-aaa-bbb**
- **kubectl set env deploy/mydb MARIADB_ROOT_PASSWORD=secret**

# Click to edit Master title styleKubernetes in 4 Hours

## Accessing applications from

## Outside

# Click to edit Master title style

# Understanding Pod Access

- Pods are connected to the pod network. The pod network is behind
  the firewall, and its addresses cannot be directly accessed
- As typically multiple instances of pods are started, a load balancer is
  needed to connect incoming user requests to a specific pod
- This API-based load balancing functionality is offered by the _Service_
  resource
- The service provides one single IP-address that should be addressed
  to connect to a specific pod

# Click to edit Master title style

# Understanding Ingress

- _Ingress_ is an additional resource, that provides external access to
  HTTP and HTTPS based services
- _Ingress_ also defines a virtual service name to provide easy access to
  services
- Different Ingress solutions are provided by the Kubernetes
  ecosystem

# Click to edit Master title style

# Understanding Service Types

- **ClusterIP** is accessible from within the cluster only
- **NodePort** exposes an external port on the cluster nodes, thus
  providing a primitive way for offering access to the services
- _Ingress_ is what should be used to provide user-friendly access to
  services

# Click to edit Master title style

# Demo: Using Services - 1

- **kubectl create deployment nginxsvc --image=nginx**
- **kubectl scale deployment nginxsvc --replicas=3**
- **kubectl expose deployment nginxsvc --port=80**
- **kubectl describe svc nginxsvc** # look for endpoints
- **kubectl get svc**
- **kubectl get endpoints**

# Click to edit Master title style

# Demo: Using Services - 2

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

# Click to edit Master title styleKubernetes in 4 Hours

## Working with Storage

# Click to edit Master title style

# Understanding Container Storage

- Container storage by nature is ephemeral
- To provide persistent storage, the Pod specification can define
  containers as well as volumes
- The pod volumes can be used to refer to any type of storage
- Use **kubectl explain pod.spec.volumes** to see which volume types
  are supported

# Click to edit Master title style

# Demo

1. **kubectlcreate -f morevolumes.yaml**
2. **kubectlget pods morevol2**
3. **kubectldescribe pods morevol2 | less** ## verify there are
   two containers in the pod
4. **kubectlexec -timorevol2 -c centos1 --touch /centos1/test**
5. **kubectlexec -timorevol2 -c centos2 --ls -l /centos2**

# Click to edit Master title styleKubernetes in 4 Hours

## Using ConfigMaps

# Click to edit Master title style

# Understanding ConfigMaps

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

# Click to edit Master title style

# Creating ConfigMaps - Overview

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

# Click to edit Master title style

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

# Click to edit Master title styleKubernetes in 4 Hours

## Summary

# Click to edit Master title style

# Next Steps

- To learn more, consider one of the following live courses
  - Kubernetes in 3 weeks
  - GitOpsand Kubernetes Automation in 3 weeks
  - CKAD Crash Course
  - CKA Crash Course
  - Managing MicroServiceswith Kubernetes and Istio
- Or one of the following recorded courses
  - Getting Started with Kubernetes3/ed
  - Hands on Kubernetes
  - Certified Kubernetes Application Developer
  - Certified Kubernetes Administrator
