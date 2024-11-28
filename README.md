# ColumnCounter

## ざっくり仕様

- Excel ブックのシートを開く
- ヘッダを取る
- ヘッダごとの列をカウントする
- 列名 | 件数
  - でブックに出力

- ConsoleApp/.Net 9.0\
- param
  - in: book / sheetName
    - DB: host, database, table
  - out: book / sheetName

## リポジトリの運用

- feature/{issue no.} のブランチを作って pull req してください
- issue に関係のないものはまぜないでください(.gitignore を足したい場合など issue を切ってから pull req してください)
