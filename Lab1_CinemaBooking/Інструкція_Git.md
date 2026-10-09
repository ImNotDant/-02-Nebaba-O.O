# Git-завдання

Виконайте команди в терміналі з каталогу `Lab1_CinemaBooking`. Потрібно мати встановлені Git, .NET SDK 10 і обліковий запис GitHub/GitLab для створення PR.

## 1. Ініціалізація та перший commit

```bash
git init
git switch -c main
git add .
git commit -m "Create initial repository"
```

## 2. Створення гілки лабораторної роботи

```bash
git switch -c lab/01-git
```

## 3. Зробіть щонайменше три commits

Якщо всі файли вже додані першим commit, зробіть подальші осмислені зміни (наприклад, доповніть README або відповіді) та фіксуйте їх окремо:

```bash
git add README.md
git commit -m "Add project README"

git add src/
git commit -m "Add .NET solution and projects"

git add Контрольні_питання.md Інструкція_Git.md
git commit -m "Add lab answers and Git instructions"
```

Перевірте історію:

```bash
git status
git log --oneline --graph --all
```

## 4. Віддалений репозиторій і Pull Request

Створіть порожній репозиторій на GitHub або GitLab, потім підставте його URL:

```bash
git remote add origin <URL_ВАШОГО_РЕПОЗИТОРІЮ>
git push -u origin main
git push -u origin lab/01-git
```

На сайті створіть Pull Request із `lab/01-git` до `main`. Після перевірки виконайте Merge у вебінтерфейсі або за інструкціями вашої платформи.

## 5. Створення тегу lab-01

Після merge перейдіть на main і створіть тег:

```bash
git switch main
git pull
git tag lab-01
git push origin lab-01
```

Перевірити тег:

```bash
git tag
```

> Примітка: якщо репозиторій уже містить перший commit з усіма файлами, не повторюйте команди створення тих самих файлів. Зробіть окремі реальні зміни між наступними commits.
