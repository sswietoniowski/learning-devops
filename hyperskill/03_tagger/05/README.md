# Objectives

Add the get_month_name function to the `main.py` file:

```bash
cat <<EOF >> main.py
def get_month_name():
    date_obj = datetime.utcnow()
    month_name = date_obj.strftime('%m')
    return month_name
EOF
```

Add changes to the staging area:

```bash
git add main.py
```

Commit changes with the message `feat: Month names`:

```bash
git commit -m "feat: Month names"
```

Create an annotated tag by increasing your last tag's minor version by one with the message `Month name functionality`:

```bash
git tag -a 0.2.0 -m "Month name functionality"
```

Push the modifications and tags to the remote's `main` branch:

```bash
git push origin main --tags
```
