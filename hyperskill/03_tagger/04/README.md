# Objectives

Delete the `v0` tag from the local repository:

```bash
git tag -d v0
```

Delete the `v0` tag from the remote repository:

```bash
git push origin :refs/tags/v0
```

For your most recent commit, create the annotated tag `0.1.0` with the message `Day name functionality`:

```bash
git tag -a 0.1.0 -m "Day name functionality"
```

Push the tag to the remote's `main` branch:

```bash
git push origin main --tags
```
