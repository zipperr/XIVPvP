# Introduction
## XIVPvPとは
PVP時の情報を集めるツールらしいです。

## 目的
本家開発が終わってしまったため、もう一度動かしてみよう！という有志をつのっている状態です。

## ゴール
zipを喜ばせる

## 2022.05.02 コンバート作業開始

Cでやっているとどうしても効率が落ちがちなので
C Sharpへ移行します。

# 環境構築
当開発はデバッグの都合上、git-submoduleを導入しています。
git submoduleについては man git-submodule等で各自確認してください。

必須項目は
1. git
2. docker
です。

# git

### git cloneを行う際に

下記 recursive cloneを行って下さい。

```shell
git clone --recursive git@github.com:zipperr/XIVPvPbrowser.git
```

### recursive cloneを行っていない方向け
下記を実行してください。

```shell
git submodule update --init --recursive
```

## git-flow
入れても入れなくても良いですが、git-flowを入れると便利です。
git-flowについての説明は
1. https://qiita.com/KosukeSone/items/514dd24828b485c69a05
2. https://cloudsmith.co.jp/blog/efficient/2020/08/1534208.html
が分かりやすいかもしれません。

# docker
Windows/Mac/Linuxでデバッグを出来るようにすることを目標としている為、必須です。

https://www.docker.com/products/docker-desktop/

# デバッグ環境立ち上げ方
デタッチオプションは付けないで実行しているのはログ出力が必須な為です。

```shell
docker-compose up
```