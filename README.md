# Book REST API 
`commands.yml`.

## Install

    

## Run the app

   dotnet run

## Run the tests



# REST API

The REST API to the example app is described below.

## Get list of Books

### Request

`GET /books/`

    curl -i -H 'Accept: application/json' http://localhost:5001/books/

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 2

    []

## Create a new Book

### Request

`POST /Book/`

    curl -i -H 'Accept: application/json' -d 'name=Foo&status=new' http://localhost:5001/books

### Response

    HTTP/1.1 201 Created
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 201 Created
    Connection: close
    Content-Type: application/json
    Location: /thing/1
    Content-Length: 36

    {"id":1,"title":"The River Between "author":"Ngugi wa Thiong'o","Description":"some book description"}

## Get a specific Book

### Request

`GET /books/id`

    curl -i -H 'Accept: application/json' http://localhost:5001/books/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 36

   {"id":1,"title":"The River Between "author":"Ngugi wa Thiong'o","Description":"some book description"}

## Get a non-existent Book

### Request

`GET /books/id`

    curl -i -H 'Accept: application/json' http://localhost:5001/books/9999

### Response

    HTTP/1.1 404 Not Found
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 404 Not Found
    Connection: close
    Content-Type: application/json
    Content-Length: 35

    {"status":404,"reason":"Not found"}

## Create another new Book

### Request

`POST /books/`

    curl -i -H 'Accept: application/json' -d 'name=Bar&junk=rubbish' http://localhost:5001/books

### Response

    HTTP/1.1 201 Created
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 201 Created
    Connection: close
    Content-Type: application/json
    Location: /thing/2
    Content-Length: 35

   {"id":2 ,"title":"Another book","Author":"some writer","description":"some book description"}

## Get list of Things Books

### Request

`GET /books/`

    curl -i -H 'Accept: application/json' http://localhost:5001/books/

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 74

    [{"id":1,"title":"The River Between "author":"Ngugi wa Thiong'o","Description":"some book description"},{"id":2 ,"title":"Another book","Author":"some writer","description":"some book description"}]

## Change a Book's state

### Request

`PUT /book/id/`

    curl -i -H 'Accept: application/json' -X PUT http://localhost:5001/books/2

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 40

    {"id":1,"title":"Foo","author":"someone else","description":"other descr"}

## Get changed Book

### Request

`GET /books/id`

    curl -i -H 'Accept: application/json' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 40

        {"id":1,"title":"Foo","author":"someone else","description":"other descr"}



## Delete a Book

### Request

`DELETE /books/id`

    curl -i -H 'Accept: application/json' -X DELETE http://localhost:7000/thing/1/

### Response

    HTTP/1.1 204 No Content
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 204 No Content
    Connection: close


## Try to delete same Thing again

### Request

`DELETE /books/id`

    curl -i -H 'Accept: application/json' -X DELETE http://localhost:7000/thing/1/

### Response

    HTTP/1.1 404 Not Found
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 404 Not Found
    Connection: close
    Content-Type: application/json
    Content-Length: 35

    {"status":404,"reason":"Not found"}

## Get deleted Book

### Request

`GET /books/1`

    curl -i -H 'Accept: application/json' http://localhost:7000/thing/1

### Response

    HTTP/1.1 404 Not Found
    Date: Thu, 24 Feb 2011 12:36:33 GMT
    Status: 404 Not Found
    Connection: close
    Content-Type: application/json
    Content-Length: 35

    {"status":404,"reason":"Not found"}


