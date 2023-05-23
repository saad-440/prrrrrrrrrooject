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
<form>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="inputEmail4">Email</label>
      <input type="email" name="email" class="form-control" id="inputEmail4">
    </div>
    <div class="form-group col-md-6">
      <label for="inputPassword4">Password</label>
      <input type="password" name="Password"  class="form-control" id="inputPassword4">
    </div>
  </div>
  <div class="form-group">
    <label for="inputAddress">Address</label>
    <input type="text" name="Address"  class="form-control" id="inputAddress" placeholder="1234 Main St">
  </div>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="inputCity">City</label>
      <input type="text" name="City" class="form-control" id="inputCity">
    </div>
  </div>
  <div class="form-group">
    </div>
  </div>
  <button type="submit" class="btn btn-primary">Sign in</button>
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
        email = form_data['email'][0]
        Password = form_data['Password'][0]
        Address= form_data['Address'][0]
        City = form_data['City'][0]

        # Insert the data into the database
        cnx = mysql.connector.connect(
            user='root', password='192837', host='localhost', database='web_application_form')
        cursor = cnx.cursor()
        query = "INSERT INTO mafomr (email, _Password, Address, City) VALUES (%s, %s, %s, %s)"
        data = (email, Password, Address, City)
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