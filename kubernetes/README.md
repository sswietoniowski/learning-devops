# Kubernetes

This directory contains resources that help grasp the basics of Kubernetes.

## Table of Contents

- [Kubernetes](#kubernetes)
  - [Table of Contents](#table-of-contents)
  - [Directory Contents](#directory-contents)
  - [Learning Resources](#learning-resources)
  - [Useful Tools \& Other Resources](#useful-tools--other-resources)

## Directory Contents

This directory contains the following sub-directories:

- [projects](projects/) demo project(-s) created using Kubernetes.

## Learning Resources

Based on these (free) courses & articles:

- ✅ [What is Kubernetes](https://youtu.be/VnvRFRk_51k),
- [Kubernetes Tutorial for Beginners](https://youtu.be/X48VuDVv0do),
- [Kubernetes The Much Harder Way](https://youtu.be/bpp5tpgU6CE),
- ✅ [How to deploy .NET apps to Kubernetes](https://youtu.be/cNlxPKy_NPA),
- ✅ [Translate a Docker Compose File to Kubernetes Resources](https://kubernetes.io/docs/tasks/configure-pod-container/translate-compose-kubernetes/),
- 📖 [Selecting Between Docker Desktop, Rancher Desktop and Podman Desktop](https://www.acorn.io/resources/blog/selecting-between-docker-desktop-rancher-desktop-and-podman-desktop),
- 📖 [Podman Desktop, an alternative to Docker Desktop](https://4sysops.com/archives/podman-desktop-an-alternative-to-docker-desktop/),
- 📖 [Creating a local cluster with Kubernetes KinD](https://github.com/salaboy/platforms-on-k8s/tree/main/chapter-2#creating-a-local-cluster-with-kubernetes-kind),
- 📖 [Conference Application Helm Chart :: K8s](https://github.com/salaboy/platforms-on-k8s/tree/main/conference-application/helm/conference-app),
- 📖 [Performing a Rolling Update](https://kubernetes.io/docs/tutorials/kubernetes-basics/update/update-intro/),
- 📖 [Deploy and Access the Kubernetes Dashboard](https://kubernetes.io/docs/tasks/access-application-cluster/web-ui-dashboard/),
- 📖 [Tekton in Action](https://github.com/salaboy/platforms-on-k8s/tree/main/chapter-3/tekton),
- 📖 [Tekton for Service Pipelines](https://github.com/salaboy/platforms-on-k8s/tree/main/chapter-3/tekton#tekton-for-service-pipelines),
- 📖 [Dagger Quickstart](https://docs.dagger.io/quickstart/),
- 📖 [Dagger in Action](https://github.com/salaboy/platforms-on-k8s/blob/main/chapter-3/dagger/README.md),
- 📖 [Environment Pipelines](https://github.com/salaboy/platforms-on-k8s/blob/main/chapter-4/README.md),
- 📖 [Multi-Cloud (App) Infrastructure](https://github.com/salaboy/platforms-on-k8s/tree/main/chapter-5),
- 📖 [Let's build a Platform on top of Kubernetes](https://github.com/salaboy/platforms-on-k8s/tree/main/chapter-6),
- 📖 [What is OpenGitOps](https://opengitops.dev/),
- 📖 [Infrastructure as Code, part 1: create a Kubernetes cluster with Terraform](https://circleci.com/blog/learn-iac-part1/),
- 📖 [Infrastructure as Code, part 2: build Docker images and deploy to Kubernetes with Terraform](https://circleci.com/blog/learn-iac-part02/),
- 📖 [Infrastructure as Code, part 3: automate Kubernetes deployments with CI/CD and Terraform](https://circleci.com/blog/learn-iac-part3/),
- 📖 [CNCF Platforms White Paper](https://tag-app-delivery.cncf.io/whitepapers/platforms/),
- ✅ 🎥 [What is Platform Engineering and how it fits into DevOps and Cloud world](https://youtu.be/ghzsBm8vOms?si=1V4bRWcwMYQdgqLk) :+1:,
- 🎥 [DevOps vs SRE vs Platform Engineering | Clear Big Misconceptions](https://youtu.be/an8SrFtJBdM?si=MWQKZG2XUyBEUao_),
- 🎥 [Platform Engineering as a (Community) Service](https://youtu.be/4N2ywun-wTE?si=i0mspvdugtL7cK2e),
- 🎥 [Where Platform Engineering GOES WRONG](https://youtu.be/vw8PUPit7lc?si=ATLyKxbnXKv4sSix),
- 🎥 [Platform Engineering vs DevOps](https://youtu.be/m1FBrO3ekkU?si=FKEotygghltyaH6O),
- 📖 [Cost-Effective Multi-tenancy on Kubernetes](https://www.salaboy.com/2023/06/19/cost-effective-multi-tenancy-on-kubernetes/).

I also used these (paid) courses & books:

- [Kubernetes for Developers: Core Concepts](https://app.pluralsight.com/library/courses/kubernetes-developers-core-concepts/table-of-contents) [:file_folder:](https://app.pluralsight.com/library/courses/kubernetes-developers-core-concepts/exercise-files) ▶️,
- [Kubernetes for Developers: Deploying Your Code](https://app.pluralsight.com/library/courses/kubernetes-developers-deploying-code/table-of-contents) [:file_folder:](https://app.pluralsight.com/library/courses/kubernetes-developers-deploying-code/exercise-files),
- [Kubernetes for Developers: Integrating Volumes and Using Multi-container Pods](https://app.pluralsight.com/library/courses/kubernetes-developers-integrating-volumes-using-multi-container-pods/table-of-contents) [:file_folder:](https://app.pluralsight.com/library/courses/kubernetes-developers-integrating-volumes-using-multi-container-pods/exercise-files),
- [Kubernetes for Developers: Moving from Docker Compose to Kubernetes](https://app.pluralsight.com/library/courses/kubernetes-developers-docker-compose-kubernetes/table-of-contents) [:file_folder:](https://app.pluralsight.com/library/courses/kubernetes-developers-docker-compose-kubernetes/exercise-files),
- [Kubernetes for Developers: Moving to the Cloud](https://app.pluralsight.com/library/courses/kubernetes-developers-moving-cloud/table-of-contents) [:file_folder:](https://app.pluralsight.com/library/courses/kubernetes-developers-moving-cloud/exercise-files),
- O'Reilly Live Events:
  - ✅ 🎥 [Kubernetes in 4 Hours](https://learning.oreilly.com/live-events/kubernetes-in-4-hours/0636920056367/) [:file_folder:](https://on24static.akamaized.net/event/41/29/94/9/rt/1/documents/resourceList1688561051460/kubernetes36231688561042958.pdf) [:file_folder:](https://github.com/sandervanvugt/kubernetes),
  - [Kubernetes in 3 Weeks: Part 1 — Containers, Microservices, Pods, and Common Objects](https://learning.oreilly.com/live-events/kubernetes-in-3-weeks-part-1containers-microservices-pods-and-common-objects/0636920385158/),
  - [Kubernetes GitOps With Flux and ArgoCD](https://learning.oreilly.com/live-events/kubernetes-gitops-with-flux-and-argocd/0636920078987/),
  - [Continuous Delivery in Kubernetes with ArgoCD](https://learning.oreilly.com/live-events/continuous-delivery-in-kubernetes-with-argocd/0636920054359/),
  - ✅ 🎥 [Getting Started with OpenShift](https://learning.oreilly.com/live-events/getting-started-with-openshift/0636920244301/) [:file_folder:](https://on24static.akamaized.net/event/42/49/56/5/rt/1/documents/resourceList1691176707348/openshiftfundamentals51691176706197.pdf) [:file_folder:](https://github.com/sandervanvugt/openshift),
- 🎥 [From Zero to Hero: Kubernetes for Developers](https://dometrain.com/course/from-zero-to-hero-kubernetes-for-developers/),
- 📖 [Platform Engineering on Kubernetes](https://learning.oreilly.com/library/view/platform-engineering-on/9781617299322/) [:file_folder:](https://github.com/salaboy/from-monolith-to-k8s),
- 📖 [Continuous Delivery: Reliable Software Releases through Build, Test, and Deployment Automation](https://learning.oreilly.com/library/view/continuous-delivery-reliable/9780321670250/),
- 📖 [Grokking Continuous Delivery](https://learning.oreilly.com/library/view/grokking-continuous-delivery/9781617298257/).

## Useful Tools & Other Resources

Some useful tools & other resources:

- Sandboxes:
  - [Killercoda](https://killercoda.com/playgrounds/scenario/kubernetes) [:file_folder:](https://github.com/killercoda/scenario-examples) - Kubernetes playground at **Killercoda**,
  - [Play with Kubernetes](https://labs.play-with-k8s.com/) - Kubernetes playground at **Play with Kubernetes**,
  - [Free Kubernetes](https://github.com/learnk8s/free-kubernetes) - list of Free Trials of Managed Kubernetes Services,
  - [Developer Sandbox for Red Hat OpenShift](https://developers.redhat.com/developer-sandbox) - free OpenShift cluster for 30 days,
- Distributions & Tools:
  - [kubectl](https://kubernetes.io/docs/tasks/tools/) - the Kubernetes command-line tool,
  - [Docker and Kubernetes](https://www.docker.com/resources/kubernetes-and-docker/) - replicate production environments on your local machine,
  - [Red Hat OpenShift Local](https://developers.redhat.com/products/openshift-local/overview) - the quickest way to start building OpenShift clusters.
  - [minikube](https://github.com/kubernetes/minikube) - run Kubernetes locally,
  - [kind](https://kind.sigs.k8s.io/) - a tool for running local Kubernetes clusters using Docker container "nodes",
  - [OKD](https://www.okd.io/) - the community distribution of Kubernetes that powers RedHat OpenShift,
  - [vCluster](https://www.vcluster.com/) - enabling the rapid creation of virtual clusters, which can isolate 100s of different tenant workloads within one cluster,
  - [OperatorHub](https://operatorhub.io/) - a new home for the Kubernetes community to share Operators,
  - [Operator SDK](https://sdk.operatorframework.io/) - the Operator SDK makes it easier to build Kubernetes native applications, a process that can require deep, application-specific operational knowledge,
- Template Engines:
  - [Kustomize](https://kustomize.io/) - a template-free way to customize application configuration,
  - [Carvel YTT](https://carvel.dev/ytt/) - template and patch as needed to make your configuration reusable and extensible easily,
  - [Helm Templates](https://helm.sh/docs/chart_best_practices/templates/#helm),
- [Kompose](https://kompose.io/) - convert Docker Compose files to Kubernetes resources,
- Package Managers:
  - [Imgpkg](https://carvel.dev/imgpkg/) - package, distribute, and relocate your Kubernetes configuration and dependent OCI images as one OCI artifact,
  - [Kapp](https://carvel.dev/kapp/) - deploy and view groups of Kubernetes resources as "applications",
  - [Helm](https://helm.sh/) - the package manager for Kubernetes,
  - [helmfile](https://github.com/helmfile/helmfile) - declaratively deploy your Kubernetes manifests, Kustomize configs, and Charts as Helm releases,
- Infrastructure as Code (IaC):
  - [Terraform](https://www.terraform.io/) - infrastructure automation to provision and manage resources in any cloud or data center,
  - [Pulumi](https://www.pulumi.com/) - infrastructure as Code in Any Programming Language,
  - [Ansible](https://www.ansible.com/) - an open source IT automation engine that automates provisioning, configuration management, application deployment, orchestration, and many other IT processes,
  - [Puppet](https://www.puppet.com/) - a freely available open source configuration management platform that allows you to automate your infrastructure as code,
  - [Chef](https://www.chef.io/) - configure, deploy and manage your entire application infrastructure in a secure and compliant way,
  - [Crossplane](https://www.crossplane.io/) - build control planes without needing to write code,
- [Ingress Controllers](https://docs.google.com/spreadsheets/d/191WWNpjJ2za6-nbG4ZoUMXMpUK8KlCIosvQB0f-oq3k/edit?pli=1&gid=907731238#gid=907731238) - Kubernetes Ingress Controllers,
- Management:
  - [k9s](https://k9scli.io/) - a terminal-based UI to interact with your Kubernetes clusters,
  - [skooner](https://github.com/skooner-k8s/skooner) - simple Kubernetes real-time dashboard and management,
  - [Lens](https://k8slens.dev) - the way the world runs Kubernetes,
  - [OpenLens](https://github.com/MuhammedKalkan/OpenLens) [:file_folder:](https://github.com/lensapp/lens) - OpenLens Binary Build Repository,
  - [VSCode Kubernetes Tools](https://marketplace.visualstudio.com/items?itemName=ms-kubernetes-tools.vscode-kubernetes-tools) - Kubernetes extension for Visual Studio Code,
- Observability:
  - [OpenTelemetry](https://opentelemetry.io/) - high-quality, ubiquitous, and portable telemetry to enable effective observability,
  - [Prometheus](https://prometheus.io/docs/introduction/overview/) - an open-source systems monitoring and alerting toolkit,
  - [Grafana](https://grafana.com/) - collect, correlate, and visualize data with beautiful dashboards using our open-source data visualization and monitoring solution,
- Identity Providers:
  - [Keycloak](https://www.keycloak.org/) - Open Source Identity and Access Management,
  - [Zitadel](https://zitadel.com/opensource) - the open-source identity and access management solution,
  - [Duende Identity Server](https://duendesoftware.com/products/identityserver) - flexible and standards-compliant OpenID Connect and OAuth 2.0 framework for ASP.NET Core,
- CI/CD Tools:
  - [Argo CD](https://argo-cd.readthedocs.io/en/stable/) - a declarative, GitOps continuous delivery tool for Kubernetes,
  - [GitHub Actions](https://github.com/features/actions) - GitHub Actions makes it easy to automate all your software workflows,
  - [GitLab CI/CD](https://docs.gitlab.com/ee/ci/) - a continuous and iterative process to build, test, and deploy,
  - [Tekton](https://tekton.dev/) - a powerful and flexible open-source framework for creating CI/CD systems,
  - [Tekton Catalog](https://github.com/tektoncd/catalog) - a catalog of shared Tasks and Pipelines,
  - [Tekton Hub](https://hub.tekton.dev/) - discover, search, and share reusable Tasks and Pipelines,
  - [Dagger](https://dagger.io/) - powerful, programmable open-source CI/CD engine that runs your pipelines in containers,
  - [TeamCity](https://www.jetbrains.com/teamcity/) - an advanced CI/CD solution that allows for flexible workflows, collaboration, and development practices,
  - [Octopus Deploy](https://octopus.com/) - deploy your software to multi-cloud, hybrid, and on-premises environments with ease,
  - [Jenkins](https://www.jenkins.io/) - the leading open-source automation server, Jenkins provides hundreds of plugins to support building, deploying, and automating any project,
  - [Jenkins X](https://jenkins-x.io/) - Multi-cluster GitOps, Tekton pipelines, Secrets management, Pull Request ChatOps and Preview Environments,
- Others:
  - [postgres-operator](https://github.com/zalando/postgres-operator) - Postgres operator creates and manages PostgreSQL clusters running in Kubernetes,
  - [external-secrets](https://github.com/external-secrets/external-secrets) - External Secrets Operator reads information from a third-party service like AWS Secrets Manager and automatically injects the values as Kubernetes Secrets,
  - [HashiCorp Vault](https://www.vaultproject.io/) - secure, store, and tightly control access to tokens, passwords, certificates, and encryption keys for protecting secrets and other sensitive data using a UI, CLI, or HTTP API,
  - [Kratix](https://www.kratix.io/) - an open-source platform framework for building composable internal developer platforms (IDPs),
  - [Dapr](https://dapr.io/) - provides integrated APIs for communication, state, and workflow, leverages industry best practices for security, resiliency, and observability, so you can focus on your code,
  - [OpenFeature](https://openfeature.dev/) - standardizing Feature Flagging for Everyone,
  - [KEDA](https://keda.sh/) - a Kubernetes-based Event Driven Autoscaler,
  - [CNCF Buildpacks](https://buildpacks.io/) - Cloud Native Buildpacks transform your application source code into images that can run on any cloud.
