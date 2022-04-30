# Introduction
## XIVPvPとは
PVP時の情報を集めるツールらしい。

## 目的
本家開発が終わってしまったため、もう一度動かしてみよう！という有志をつのっている状態です。

## ゴール
zipを喜ばせる


# 環境構築

注意: Linux環境下でMinGWをインストールしてみたところ
distroによって差異があるらしくmakeできないので下記をおススメします。

## 1. GitHub Desktop

### 1-1. GitHub Desktopのセットアップ
https://desktop.github.com/
上記からDLを行いアカウントと紐づける

### 1-2. zipにGithubアカウントを通達
表題の通り通達を行い、招待メール送信申請を行う

## 2. MinGWダウンロード
1. 下記から mingw-18.0.exeをDL
https://nuwen.net/mingw.html

## 3. セットアップ完了後パスを通す
https://qiita.com/shuhey/items/7ee0d25f14a997c9e285

## 4. python for windowsをインストール
https://www.python.org/downloads/windows/
よりダウンロード＆インストール

## 5. XIV_Browserをセットアップ
### 5-1. 下記よりClone
https://github.com/zipperr/XIVPvPbrowser

### 5-2. XIV_Browserのディレクトリにて実行

```
pip install -r requirements.txt
```

# 立ち上げ方

## 1. XIVPVP
1. 管理者権限にてmake終わったファイルを実行

## 2. XIV_Browser

```
python app.py
```
