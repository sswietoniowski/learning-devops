# Docker

This directory contains resources that help grasp the basics of Docker.

## Table of Contents

- [Docker](#docker)
  - [Table of Contents](#table-of-contents)
  - [Directory Contents](#directory-contents)
  - [Learning Resources](#learning-resources)
  - [Useful Tools \& Other Resources](#useful-tools--other-resources)

## Directory Contents

This directory contains the following sub-directories:

- [projects](projects/) demo project(-s) created using Kubernetes.

## Learning Resources

Based on these (free) courses:

- courses:
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
- others:
  - [Infrastructure as Code, part 1: create a Kubernetes cluster with Terraform](https://circleci.com/blog/learn-iac-part1/),
  - [Infrastructure as Code, part 2: build Docker images and deploy to Kubernetes with Terraform](https://circleci.com/blog/learn-iac-part02/),
  - [Infrastructure as Code, part 3: automate Kubernetes deployments with CI/CD and Terraform](https://circleci.com/blog/learn-iac-part3/).

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
- 📖 [Platform Engineering on Kubernetes](https://learning.oreilly.com/library/view/platform-engineering-on/9781617299322/) [:file_folder:](https://github.com/salaboy/from-monolith-to-k8s).

## Useful Tools & Other Resources

Some useful tools & other resources:

- Sandboxes:
  - [Killercoda](https://killercoda.com/playgrounds/scenario/kubernetes) [:file_folder:](https://github.com/killercoda/scenario-examples) - Kubernetes playground at **Killercoda**,
  - [Play with Kubernetes](https://labs.play-with-k8s.com/) - Kubernetes playground at **Play with Kubernetes**,
  - [Free Kubernetes](https://github.com/learnk8s/free-kubernetes) - list of Free Trials of Managed Kubernetes Services,
  - [Developer Sandbox for Red Hat OpenShift](https://developers.redhat.com/developer-sandbox) - free OpenShift cluster for 30 days,
- Distributions:
  - [OKD](https://www.okd.io/) - the community distribution of Kubernetes that powers RedHat OpenShift,
  - [Red Hat OpenShift Local](https://developers.redhat.com/products/openshift-local/overview) - the quickest way to get started building OpenShift clusters.
  - [minikube](https://github.com/kubernetes/minikube) - run Kubernetes locally,
  - [kind](https://kind.sigs.k8s.io/) - a tool for running local Kubernetes clusters using Docker container "nodes",
- Template Engines:
  - [Kustomize](https://kustomize.io/) - a template-free way to customize application configuration,
  - [Carvel YTT](https://carvel.dev/ytt/) - template and patch as needed to easily make your configuration reusable and extensible,
  - [Helm Templates](https://helm.sh/docs/chart_best_practices/templates/#helm),
- [Kompose](https://kompose.io/) - convert Docker Compose files to Kubernetes resources,
- Package Managers:
  - [Imgpkg](https://carvel.dev/imgpkg/) - package, distribute, and relocate your Kubernetes configuration and dependent OCI images as one OCI artifact,
  - [Kapp](https://carvel.dev/kapp/) - deploy and view groups of Kubernetes resources as "applications",
  - [Helm](https://helm.sh/) - the package manager for Kubernetes,
- Infrastructure as Code (IaC):
  - [Terraform](https://www.terraform.io/) - infrastructure automation to provision and manage resources in any cloud or data center,
  - [Pulumi](https://www.pulumi.com/) - infrastructure as Code in Any Programming Language,
- [Ingress Controllers](https://docs.google.com/spreadsheets/d/191WWNpjJ2za6-nbG4ZoUMXMpUK8KlCIosvQB0f-oq3k/edit?pli=1&gid=907731238#gid=907731238) - Kubernetes Ingress Controllers,
- Management:
  - [k9s](https://k9scli.io/) - a terminal based UI to interact with your Kubernetes clusters,
  - [skooner](https://github.com/skooner-k8s/skooner) - simple Kubernetes real-time dashboard and management,
- Observability:
  - [OpenTelemetry](https://opentelemetry.io/) - high-quality, ubiquitous, and portable telemetry to enable effective observability,
  - [Prometheus](https://prometheus.io/docs/introduction/overview/) - an open-source systems monitoring and alerting toolkit,
  - [Grafana](https://grafana.com/) - collect, correlate, and visualize data with beautiful dashboards using our open source data visualization and monitoring solution.
