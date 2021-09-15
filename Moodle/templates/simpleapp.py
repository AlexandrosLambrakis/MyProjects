from flask import Flask, render_template, request,session
import sqlite3 as sql
app = Flask(__name__)

@app.route('/')
def home():
   return render_template('home.html')

@app.route('/enternew')
def new_student():
   return render_template('student.html')

@app.route('/form')
def form():
   error=None
   return render_template('login.html', error = error)


def retrieveusers():
 con=sql.connect("moodle.db")
 cur=con.cursor()
 cur.execute("SELECT username, password,firstname,lastname,role FROM users")
 users=cur.fetchall()
 con.close()
 return users



@app.route('/addrec',methods = ['POST', 'GET'])
def addrec():
   if request.method == 'POST':
      try:
         username = request.form['username']
         password = request.form['password']
         firstname = request.form['firstname']
         lastname = request.form['lastname']
         
         with sql.connect("moodle.db") as con:
            cur = con.cursor()
            
            cur.execute("INSERT INTO users (username,password,firstname,lastname,role)VALUES(?,?,?,?,?)",(username,password,firstname,lastname,"student"))
            
            con.commit()
            msg = "Record successfully added"
      except:
         con.rollback()
         msg = "error in insert operation"
      
      finally:
         return render_template("result.html",msg = msg)
         con.close()

@app.route('/list')
def list():
   print (retrieveusers())
   return render_template("list.html",rows = retrieveusers())


@app.route('/login', methods = ['GET', 'POST'])
def login():
   error = None

   username = request.form['Username']
   password = request.form['Password']
   users = retrieveusers()
   for user in users:
      if user[0]==username and user[1]==Password:
         session['user'] = users
         if user[4]=="teacher":
            return render_template('home.html')
            flash('You were successfully logged in')
         else:
            return render_template('student.html')
      else:
         error = 'Invalid username or password. Please try again!'
         return render_template('login.html', error = error)
   


if __name__ == '__main__':
   app.run(debug = True)




