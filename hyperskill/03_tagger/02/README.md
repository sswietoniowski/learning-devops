# Objectives

Create a script with the name `main.py` and with the content above:

```bash
cat <<EOF > main.py
from datetime import datetime


def get_day_name():
    date_obj = datetime.utcnow()
    day_name = date_obj.strftime('%A')
    return day_name
EOF
```

Add the changes to the staging area:

```bash
git add main.py
```

Make your first commit with the commit message `feat: Day name function`:

```bash
git commit -m "feat: Day name function"
```
