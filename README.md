API input örnekleri

GetOrderWithStatusByCustomerOrderNo
customerOrderNo01


Save
{
  "customerOrderNo": "customerOrderNo03",
  "fromAddress": "from adresss",
  "toAddress": "to adresss",
  "amount": 1,
  "amountTypeId": 1,
  "weight": 2,
  "weightUnitId": 1,
  "materialDto": {
    "id": 5,
    "name": "Yemek Masası"
  },
  "note": "opsiyonel notttttlar"
}


AddRangeWithMaterial
{
  "orderPackage": [
    {
  "customerOrderNo": "customerOrderNo08",
  "fromAddress": "from adresss",
  "toAddress": "to adresss",
  "amount": 1,
  "amountTypeId": 1,
  "weight": 2,
  "weightUnitId": 1,
  "materialDto": {
    "id": 1,
    "name": "Monitör"
  },
  "note": "opsiyonel notttttlar"
  },
  {
  "customerOrderNo": "customerOrderNo09",
  "fromAddress": "from adresss",
  "toAddress": "to adresss",
  "amount": 1,
  "amountTypeId": 1,
  "weight": 2,
  "weightUnitId": 1,
  "materialDto": {
    "id": 1,
    "name": "Monitör"
  },
  "note": "opsiyonel notttttlar"
  }
  ]
}




UpdateStatus
{
  "customerOrderNo": "customerOrderNo01",
  "orderStatusId": 2
}
