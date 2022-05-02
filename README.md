# HotChocolateMissingExtend
A small repo to reproduce the issue at https://github.com/ChilliCream/hotchocolate/issues/5015

The following shows the SDL output (/graphql?sdl) (trimmed for readability). Notice the `Customer` type is lacking the `extend` keyword.

```
schema {
  query: Query
}

# the type below should be prepended with 'extend'
type Customer @key(fields: "id") {
  id: String! @external
  customField: String!
}

type Query {
  _service: _Service!
  _entities(representations: [_Any!]!): [_Entity]!
}

...
```
