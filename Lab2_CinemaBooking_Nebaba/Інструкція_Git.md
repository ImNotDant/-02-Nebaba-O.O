# Git — лабораторна робота №2

```bash
git switch main
git switch -c lab/02-oop
git add src/CinemaBooking.Domain
git commit -m "Add initial domain entities"
git add src/CinemaBooking.App/Program.cs
git commit -m "Implement domain behavior"
git add README.md Контрольні_питання.md
git commit -m "Add polymorphic strategy and lab answers"
git log --oneline --graph --all
git push -u origin lab/02-oop
```

На GitHub/GitLab створіть Pull Request з `lab/02-oop` до `main` і виконайте merge після перевірки. Потім:
```bash
git switch main
git pull
git tag lab-02
git push origin lab-02
```
Якщо `origin` ще не налаштований, створіть репозиторій на GitHub/GitLab і додайте його URL командою `git remote add origin <URL>`.
