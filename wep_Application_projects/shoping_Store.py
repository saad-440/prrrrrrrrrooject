import mysql.connector
from http.server import BaseHTTPRequestHandler, HTTPServer
from urllib.parse import parse_qs


class MyHandler(BaseHTTPRequestHandler):

    def do_GET(self):
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()

        # Write HTML code to display the form
        html = '''<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"
        integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js"
        integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"
        integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.min.js"
        integrity="sha384-+sLIOodYLS7CIrQpBjl+C7nPvqq+FbNUBDunl/OZv93DB7Ln/533i8e/mZXLi/P+"
        crossorigin="anonymous"></script>
    <title>Form</title>
</head>

<body>
  <div class="container">
      <form action="/" method="post">
              <div class="col-md-6 mb-3">
        <label for="validationCustom01">Name</label>
        <input type="text" class="form-control" id="validationCustom01" required name="Name">
        <div class="valid-feedback">
          Looks good!
        </div>
      </div>
      <div class="col-md-6 mb-3">
      <label for="validationCustom02">Phone Number</label>
      <input type="text" class="form-control" id="validationCustom02" required name="Phone_Number">
      <div class="valid-feedback">
      Looks good!
      </div>
      <br>
      <label class="sr-only" for="inlineFormInputGroupUsername2">Username</label>
      <div class="input-group mb-2 mr-sm-2">
      <div class="input-group-prepend">
      <div class="input-group-text">@</div>
      </div>
      <input type="text" class="form-control" id="inlineFormInputGroupUsername2" placeholder="Username" name="UserName">
      </div>
      <label for="inputPassword6">Address</label>
      <input type="text" id="inputPassword6" class="form-control mx-sm-"  aria-describedby="passwordHelpInline" name="Address">
      <br>
      <br>
      <label for="validationCustom01">item</label>
      <input type="text" class="form-control" id="validationCustom01" required name="item">
      <br>
      <label for="validationCustom01">Amount</label>
      <input type="text" class="form-control" id="validationCustom01" required name="Amount">
      <br>
      <button type="submit" class="btn btn-primary" name="Submit">Send</button>
      </div>
      </form>
  </body>

</html>'''

        # Send the HTML code to the client
        self.wfile.write(bytes(html, 'utf-8'))
        return

    def do_POST(self):
        # Get the form data
        content_length = int(self.headers['Content-Length'])
        post_data = self.rfile.read(content_length)
        post_data = post_data.decode('utf-8')
        form_data = parse_qs(post_data)

        Name = form_data['Name'][0]
        Phone_Number = form_data['Phone_Number'][0]
        UserName= form_data['UserName'][0]
        Address = form_data['Address'][0]
        item = form_data['item'][0]
        Amount = form_data['Amount'][0]

        # Insert the data into the database
        cnx = mysql.connector.connect(
            user='root', password='192837', host='127.0.0.1', database='web_application_form')  
        cursor = cnx.cursor()
        query = "INSERT INTO shoping_store (_Name, Phone_Number, UserName, Address, item, Amount) VALUES (%s, %s, %s, %s, %s, %s)"
        data = (Name, Phone_Number, UserName, Address, item, Amount)
        cursor.execute(query, data)
        cnx.commit()
        cursor.close()
        cnx.close()

        # Send a response back to the client
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()
        self.wfile.write(bytes('SENT!!!', 'utf-8'))
        return


def run():
    httpd = HTTPServer(('localhost', 8080), MyHandler)
    print('Server started on http://localhost:8080')
    httpd.serve_forever()


if __name__ == '__main__':
    run()