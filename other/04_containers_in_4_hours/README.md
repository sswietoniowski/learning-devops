# Containers in 4 Hours

General introduction to the containers.

## Understanding Containers

The purpose of a _container_ is to start an application.

To do so, it uses a _container image_ that has _all the dependencies_ required to run the application.

Containers run in an _isolated environment_ such that different versions of libraries can be used side by side.

To run a container, a _container runtime_ is needed.

This is the layer between the host operating system (or cloud) and the container itself.

Different solutions exist to run containers

- **LXC**: Linux native containers,
- **Docker**: common solution since 2013,
- **Podman**: introduced in RHEL 8, now available on other distributions also,
- **Systemd** nspawn,
- different cloud platforms.

- Containers started as chroot directories, and have been around for a long time
  - "chroot-ing" a directory is used since the 1980's to ensure that processes can only see the contents of a specific directory
  - This functionality has further evolved into Linux namespaces
- Docker kickstarted the adoption of containers in 2013/2014
- Docker originally was based on LXC, and became a huge success because it added the Docker Registry
- Docker registry is an open platform used for distribution of container images

- System Images are used as the foundation to build your own application containers. They are not a replacement for a virtual machine
- Application Images are used to start just one application. Application containers are the standard
- To run multiple connected containers, you need to create a microservice. Use docker-compose or Kubernetes Pods to do this in an efficient way

- Containers heavily rely upon features provided by the Linux kernel
  - namespaces and chroot
  - Cgroups
- Containers on other platforms use a Linux virtual machine to provide these features
  - Did you ever wonder why Microsoft started WSL?
- Recent Windows Server can run Windows containers. which require custom Windows images

`  `![ref1]![ref4]

- A container is a running instance of an image
- Images normally are obtained from a container registry
- The image contains the application code, language runtime and libraries
- The container does NOT include an operating system kernel
- External libraries such as libc are typically provided by the host operating system, but in a container is included in the images
- While starting a container, it adds a writable layer on the top to store any changes that are made while working with the container

`  `![ref1]![ref4]

- Container images are typically shared through public registries, or by sharing mechanisms to build them easily, such as Dockerfile
- The Docker container image format has become the de facto standard image format
- Open Container Initiative (OCI) has standardized the Docker container image format

- To work with containers, you'll need to take care of distribution of images
- Manual distribution using images in tar balls is possible, but NOT recommended
- Use registries instead
  - Storing in remote registries is common, and the DockerHub registry is very common (https://hub.docker.com)
  - When using Red Hat, have a look at quay.io
  - As an alternative, consider storing in local (private) registries

`  `![ref1]![ref4]

- The container runtime is a specific part of the container engine, and two of them are commonly used:
  - CRI-O: Red Hat
  - containerd: originates from Docker
- The container runtime is taking care of specific tasks

  - Provide the mount point
  - Communicate with the kernel
  - Set up cgroups and more

- runC is a lightweight universal container runtime
- It is the default runtime defined by the Open Containers Initiative
- It is the specific part that focusses on creating containers
- As such, it's included in CRI-O as well as containerd
- Where CRI-O and containerd are adding features, like container lifecycle management and container image management

`  `![ref1]![ref4]

- To run containers in cloud, additional features are needed
  - Flexible and scalable networking
  - Scalable and flexible storage
  - Methods to connect containers together
  - Additional services for cluster-wide monitoring of service availability
- To provide for all of these, an orchestration platform is needed
- Kubernetes is the standard orchestration platform
- Almost all other orchestration platforms are based on Kubernetes
  - OpenShift
  - Rancher
- Docker swarm provides similar features but has become obsolete

1. Using a Container Platform

`  `![ref1]![ref4]

- To test container in isolation from other parts of your OS, install Docker in a Linux virtual machine
- Use Docker Desktop on top of your main computer OS to work with an integrated platform on MacOS or Windows
- Alternatively, run **podman** directly on top of Red Hat family or other distributions

- RHEL 8 and later no longer support Docker
- RHEL now provides **podman** to work with containers to run directly on top of RHEL in single-node use cases
- **podman** also works on other distributions, like recent Ubuntu\*\*
- **podman** and **docker** are fully OCI compliant, which makes replacement a non-issue\*\*
- Use **sudo dnf install container-tools** to install all you need
- **sudo dnf install podman-docker** provides docker like syntax in the podman command

`  `![ref1]![ref4]

- Why would you have to run containers with elevated privileges?
- A rootless container runs with limited user privileges and can be started by non-root users
- A root container runs with root privileges
- Rootless containers do not get an IP address
- Rootless containers cannot bind to a privileged port
- Rootless containers have limited access to the filesystem

`   `![ref1]![ref4]

Use the most recent instructions at docker.com

3. Managing Containers

`  `![ref1]![ref4]

- **docker** and **podman** are both OCI compliant and for that reason 99% compatible
- Unless mentioned otherwise, replace "docker" with "podman" to perform commands mentioned here on podman
- **podman** has a few features that don't exist in Docker - they will be covered separately

`    `![ref1]![ref4]

- Users have to be a member of the **docker** system group in order to communicate with the Docker daemon and start and manage containers
  - Use **sudo usermod –aG docker $(USERID)**
- Do NOT run containers as root!
- When using **podman** on Red Hat, rootless containers can be used and no additional configuration is required

- To run containers, registry access must be available
- When using **docker**, images are fetched from docker hub
- When using **podman**, registries are specified in /etc/containers/ registries.conf
- Use **docker search** to find the image you need
- Or use the web interface available at [https://hub.docker.com](https://hub.docker.com/)
- Run images from any registry by specifying the complete image URL: **docker run https://my.registry.com/mycontainer:latest**

- Remember: containers are just a way to start an application
  - **docker run fedora** will run the fedora:latest image, start its default application and immediately exit
  - **docker run -it fedora bash** will run the fedora:latest image, start bash, and open an interactive terminal
- Managing foreground and background state
  - **docker run -it fedora bash** will run the container in the foreground
    - Use Ctrl-p, Ctrl-q to disconnect
    - Use **exit** to quit the main application
  - **docker run -d nginx** will run the container in the background
  - **docker attach container-name** will attach to the running container if it was started with **-d** as well as an interactive terminal (**-it**)

`  `![ref1]![ref4]

- **docker ps** gives an overview of containers currently running
- Notice the container name and ID
  - If no name was provided, a name is automatically generated
  - The container ID corresponds to the name of the directory on the local Linux file system where the container is stored
- **docker ps -a** also gives an overview of containers that have been started earlier and currently are no longer running

- A container stops when its primary application stops
- Use **docker stop** to send SIGTERM to a container
- Use **docker kill** to send SIGKILL to a container
- After stopping a container, it does not disappear
- Use **docker rm** to permanently remove it

`  `![ref1]![ref4]

- Use **docker inspect** to get details about containers
- Use **docker logs** to get access to the primary application STDOUT
- Use **docker stats** for a Linux **top**-like interface about real-time container statistics

4. Performing Common Container Management

- By default, container applications are accessible from inside the container only
- To make it accessible, you'll need to publish a port
- **docker container run --name web_server -d -p 8080:80 nginx** runs the nginx image, and configures port 8080 on the docker host to port forward to port 80 in the container
- You cannot publish a port on a container that is already running
- If you're running **podman**, you cannot map to a privileged port

`  `![ref1]![ref4]

- As containers are just Linux processes, by default they'll have full access to the host system resources
- The Linux kernel provides cgroups to put a limit to this
- **docker run -d -p 8081:80 --memory="128m" nginx** sets a hard memory limit
- **docker stats**

`  `![ref1]![ref4]

- Docker inherits the Linux kernel Cgroups notion of CPU Shares
- If not specified, all containers get a CPU shares weight of 1024
- When starting a container, a relative weight expressed in CPU shares can be specified
  - **docker run -d --rm -c 512 --cpus 4 busybox dd if=/dev/zero of=/dev/null** will run the container on 4 CPUs, but with relative CPU shares set to 50% of available CPU resources
- Containers can also be pinned to a specific cpu using **--cpuset-cpus**
  - **docker run -d --rm --cpuset-cpus=0,2 --cpus 2 busybox dd=/dev/zero of=/dev/ null** will run the container on cores 0 and 2 only
- To test: use different CPU shares on two containers and force them to run on the same CPU

- Use **docker inspect <container-name-or-id>** to figure out what the container is supposed to be doing
- Use **docker exec -it <container-name-or-id> sh** to open a shell on the container and run commands locally
- Use **docker logs** to connect to the primary application STDOUT

`  `![ref1]![ref4]

- **docker run --name mydb -d mariadb**
- **docker ps; docker ps -a**
- **docker logs mariadb**
- **docker rm mydb**
- **docker run --name mydb -d --env MARIADB_ROOT_PASSWORD=password mariadb**

5. Managing Container Images

`  `![ref1]![ref4]

- Images are what a container is started from
- Ready to run container images are available in container registries
- Users can upload images to most container registries - accounts may be required
- Alternatively, you can use private registries
- Go to hub.docker.com to search for images
- Or use **docker search** to search for images

- Tags are used to specify information about a specific image version
- Tags are aliases to the image ID and will show when using **docker images**
- Tags are typically set when building the image (covered later):
  - **docker build -t username/imagename:tagname**
  - For private use, the **username** part is optional, when pushing it to a public registry it is mandatory
- Alternatively, tags can be added to existing images using **docker tag**
  - **docker tag source-image{:tag] targetimage[:tag]**
  - When adding a tag, a pointer with the new tag is made to the existing image that was tagged
- If no tag is applied, the tag **:latest** is automatically set
  - **:latest** always points to the latest version of an image
- Target image repositories can also be specified in the Docker tag

- Tags allow you to assign multiple names to images
  - A common tag is "latest", which allows you to run the latest
- Manually tag images: **docker tag myapache myapache:1.0**
  - Next, using **docker images | grep myapache** will show the same image listed twice, as 1.0 and as latest
- Tags can also be used to identify the target registry

  - **docker tag myapache localhost:5000/myapache:1.0**

- Roughly, there are three approaches to creating an image
- Using a running container: a container is started and modifications are applied to the container. From the container, **docker** commands are used to write modifications
- Using a Dockerfile: a Dockerfile contains instructions for building an image. Each instruction adds a new layer to the image, which offers more control which files are added to which layer
- Use **buildah** on RHEL to create an image by executing commands within the image

- Dockerfile is a way to automate container builds
- Containerfile on RHEL is the same
- Notice that **docker** does not work with Containerfile, it only works with Dockerfile
- It contains all instructions required to build a container image
- Use **docker build .** to build the container image based on the Dockerfile in the current directory
- Images will be stored on your local system, but you can direct the image to be stored in a repository (covered later)

`  `![ref1]![ref4]

- FROM identifies the base image
- COPY copies a file into the image
- ADD copies a file into the image
- RUN command that is executed while building the image
- CMD command that is executed while starting the resulting image as a container
- WORKDIR defines the working directory for the CMD
- LABEL label, used as an identifier
- EXPOSE indicates the port on which the container main app offers service
- ENV provides environment variables
- USER the user used to run the container application

`  `![ref1]![ref4]

- Dockerfile demo is in https://github.com/sandervanvugt/containers/ dockerfile
- Use **docker build -t nmap .** to run it from the current directory
- Tip: use **docker build --no-cache -t nmap .** to ensure the complete procedure is performed again
- Next, use **docker run nmap** to run it
- For troubleshooting: **docker run -it nmap /bin/bash**

  - WILL NOT WORK as entrypoint is not supposed to be overwritten

- ENTRYPOINT is the default command to be processed
- If not specified, **/bin/sh -c** is executed as the default command
- Arguments to the ENTRYPOINT command should be specified separately using CMD
  - ENTRYPOINT ["command"]
  - CMD ["arg1","arg2"]
- If the default command is specified using CMD instead of ENTRYPOINT, the command is executed as an argument to the default entrypoint **sh -c** which can give unexpected results
- If the arguments to the command are specified within the ENTRYPOINT, then they cannot be overwritten from the command line

`   `**![ref1]![ref4]**

- **docker run -d --name newnginx nginx**
- **docker ps**
- **docker exec -it newnginx sh**
- **echo hello >> /tmp/testfile**
- **Ctrl-p, Ctrl-q**
- **docker diff newnginx**
- **docker commit newnginx**

`  `**![ref1]![ref4]**

- After making changes to a container, you can save it to an image
- Use **docker commit** to do so
  - **docker commit -m "custom web server" -a "Sander van Vugt" myapache myapache**
  - Use **docker images** to verify
- Next, use **docker save -o myapache.tar myapache** and transport it to anywhere you'd like
- From another system, use **docker load -i myapache.tar** to import it as an image
- Next, use **docker run myapache** to run it on that system

`  `![ref1]![ref4]

- **docker run -d -p 5000:5000 --restart=always --name registry registry:latest**
- **sudo ufw allow 5000/tcp**
- **docker pull fedora**
- **docker images**
- **docker tag fedora:latest localhost:5000/myfedora** (the tag is required to push it to your own image registry)\*\*
- **docker push localhost:5000/myfedora**
- **docker rmi fedora**; also remove the image based on the tag you've just created
- **docker exec -it registry sh; find . -name "myfedora"**
- **docker pull localhost:5000/myfedora** downloads it again from your own local registry

6. Managing Container Storage

`  `![ref1]![ref4]

- Container storage by nature is ephemeral, which means that it lasts for a very short time and nothing is done to guarantee its persistency
- When files are written, they are written to a writable filesystem layer that is added to the container image
- Notice that as a result, storage is tightly connected to the host machine
- To work with storage in containers in a more persistent and flexible way, permanent storage solutions must be used
- NFS is a common persistent storage type in non orchestrated environments
- Advanced persistent storage solutions only exist in orchestration solutions

`  `![ref1]![ref4]

- One solution is to use a bind mount to a file system on the host OS: the storage is managed by the host OS in this case
- Another solution is to connect to external (SAN or cloud-based) persistent storage solutions
- To disconnect storage from the containers using it, Volumes are used, and specific drivers can specify which volume type to connect to

`  `![ref1]![ref4]

- Bind Mount storage is based on Linux bind mounts
- The container mounts a directory or file from the host OS into the container
- If the host directory doesn't yet exist, it will be created, but only if the **-v** option is used
- The host OS still fully controls access to the file
- Docker commands cannot be used to manage the bind mount
- The **-v** option as well as the **--mount** option can be used to create the bind mount
  - **-v** is the old option, which combined multiple arguments in one field
  - **--mount** is newer and more verbose

`    `![ref1]![ref4]

Bind mounts work when the host computer contains the files that need to be accessible in the containers

- Configuration files
- Access to source code
- Log files

`  `![ref1]![ref4]

- Using **--mount**
  - **mkdir bind1; docker run --rm -d --name=bind1 --mount type=bind,source="$ (pwd)"/bind1,target=/app nginx:latest**
- Using **-v**
  - **docker run --rm -dit --name=bind2 -v "$(pwd)"/bind2:/app nginx:latest**
- Use **docker inspect <containername>** to verify
- Use **docker exec -it bind1 sh** to open a shell in the container and check

`   `![ref1]![ref4]

Volumes are the preferred way to work with persistent data as the volume survives the container lifetime

- Multiple containers can get simultaneous access to the volumes
- Data can be stored externally
- Volumes can be used to transition data from one host to another
- Volumes are supported for Linux as well as Windows containers
- Volumes live outside of the container and for that reason don't increase container size
- Volumes use drivers to specify how storage is accessed. Enterprise-grade drivers are available in Docker Swarm - not stand alone

Cl ick to edit Master title s tyle![ref1]![ref4]

- **docker run -it --name hackit --privileged -v /:/host ubi9 chroot /host**
- Docker can run rootless containers, but this is currently complex and for that reason not commonly done: https://docs.docker.com/engine/security/ rootless/

`   `![ref1]![ref4]

- **docker volume create myvol** creates a simple volume that uses the local file system as the storage backend
- **docker volume ls** will show the volume
- **docker volume inspect myvol** shows the properties of the volume
- **docker run -it --name voltest --rm --mount source=myvol,target=/data nginx:latest /bin/sh** will run a container and attach to the running volume
- From the container, use **cp /etc/hosts /data; touch /data/testfile; ctrl-p, ctrl-q**
- **sudo ls /var/lib/docker/volumes/myvol/\_data/**
- **docker run -it --name voltest2 --rm --mount source=myvol,target=/data nginx:latest /bin/sh**
- From the second container: **ls /data; touch /data/newfile; ctrl-p, ctrl-q**

`   `![ref1]![ref4]

- To just create a file in a volume, nothing special is needed and the volume can be accessed from multiple containers at the same time
- To simultaneously access files on volumes from multiple containers, a special driver is needed
- Recommended: use the **readonly** mount option to protect from file locking problems
  - **docker run -it --name voltest3 --rm --mount source=myvol,target=/ data,readonly nginx:latest /bin/sh**
- Enterprise-grade drivers are available in Docker Swarm, or are provided through Kubernetes
- For non-orchestrator use, consider using the local driver NFS type

`      `![ref1]![ref4]

- **sudo apt install nfs-server nfs-common**
- **sudo mkdir /nfsdata**
- **sudo vim /etc/exports**
  - **/nfsdata \*(rw,no_root_squash)**
- **sudo chown nobody:nogroup /nfsdata**
- **sudo systemctl restart nfs-kernel-server**
- **showmount -e localhost**
- **docker volume create --driver local --opt type=nfs --opt o=addr=192.168.4.163,rw --opt device=:/nfsdata nfsvol**
- **docker volume ls**
- **docker volume inspect nfsvol**

7. Managing Container Networking

`  `![ref1]![ref4]

- Container networking is pluggable and uses drivers
- Default drivers provide core networking
  - bridge: the default networking, allowing applications in standalone containers to communicate
  - host: removes network isolation between host and containers and allows containers to use the host network directly. In Docker, only available in swarm
  - overlay: in Swarm, allows different Docker daemons to be connected using a software defined network. Allows standalone containers on different Docker hosts to communicate
  - macvlan: assigns a MAC address to a container, making it appear as a physical device on the network. Excellent for legacy applications
  - none: completely disables networking
  - plugins: uses third-party plugins, typically seen in orchestration software

`  `![ref1]![ref4]

- Bridge networking is the default: a container network is created on internal IP address 172.17.0.0/16
- Containers will get an IP address in that range when started
- Additional bridge networks can be created
- When creating additional bridge networks, automatic service discovery is added, so that new containers can be reached by name
- There is no traffic between different bridge networks because of namespaces that provide strict isolation
- You cannot create routes from one bridge network to another bridge network, and that is by design

`    `![ref1]![ref4]

- Create a custom network
  - **docker network create –driver bridge alpine-net**
  - **docker network ls**
  - **docker network inspect alpine-net**
- Start containers on a specific network. Notice that while starting, a container can be connected to one network only. If it needs to be on two networks, you'll have to do that later
  - **docker run -dit --name alpine1 --network alpine-net alpine ash**
  - **docker run -dit --name alpine2 --network alpine-net alpine ash**
  - **docker run -dit --name alpine3 alpine ash**
  - **docker run -dit --name alpine4 --network alpine-net alpine ash**
  - **docker network connect bridge alpine4**

`    `![ref1]![ref4]

- Verify correct working
  - **docker container ls**
  - **docker network inspect bridge**
  - **docker network inspect alpine-net**
- Verify automatic service discovery, which is enabled on user defined networks
  - **docker container attach alpine1; ping alpine4**
- But notice this doesn't work on the default bridge
  - (still from alpine1) **ping alpine3**
- There's no routing either:
  - (still from alpine1) ping 172.17.0.2
- But all containers can reach out to the external network
