# Objectives

Fix the bug in the `main.py` file:

```bash
cat <<EOF > main.py
from datetime import datetime


def get_day_name():
    date_obj = datetime.utcnow()
    day_name = date_obj.strftime('%A')
    return day_name


def get_month_name():
    date_obj = datetime.utcnow()
    month_name = date_obj.strftime('%B')
    return month_name
EOF
```

Add changes to the staging area:

```bash
git add main.py
```

Commit changes with the message `fix: Bug fix month name`:

```bash
git commit -m "fix: Bug fix month name"
```

Create an annotated tag by increasing your last tag's patch version by 1 and with the message `Month name bug fix`:

```bash
git tag -a 0.2.1 -m "Month name bug fix"
```

Push the modifications and tags to the remote's `main` branch:

```bash
git push origin main --tags
```
