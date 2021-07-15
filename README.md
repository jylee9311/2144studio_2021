# 2144studio_2021
2144studio의 게임 제작을 위한 깃 레파지토리입니다!

--------------------

# branch 네이밍 규칙
어떤 방식으로 브랜치의 이름을 정하는지 브랜치 종류에 따라 살펴보자.

## master branch, develop branch

master와 develop 브랜치는 본래 이름 그대로 사용하는 경우가 일반적이다.

## feature branch

어떤 이름도 가능하다. 단, master, develop, release-..., hotfix-... 같은 이름은 사용할 수 없다.

feature/기능요약 형식을 추천한다. ex) feature/login

__feature/{issue-number}/{feature-name}__ 이슈추적을 사용한다면 이와 같은 형식을 따른다.

ex) feature/1/init-project, feature/2/build-gradle-script-write

## release branch

release-RB_... 또는 release-... 또는 release/...같은 이름이 일반적이다.

release-... 형식을 추천한다. ex) release-1.2

## hotfix branch

hotfix-... 형식을 추천한다. ex) hotfix-1.2.1
