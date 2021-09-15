from flask import Flask,render_template, request, session,url_for,redirect
import sqlite3 as sql
import models as dbHandler

app = Flask(__name__)

app.secret_key = "any random string"


@app.route('/', methods=['POST', 'GET'])
def home2():
	if request.method=='POST':
		username = str(request.form['username'])
		password = int(request.form['password'])
		users = dbHandler.retrieveUsers()
		print (users)
		for user in users:
			if user[0]==username and user[1]==password:
				session['user'] = user
				if user[4]=='teacher':
					return render_template('home.html')
				else:
					return render_template('home2.html')
			
		error = 'Invalid username or password. Please try again!'
		return render_template('login.html', error = error)

	else:
		return render_template('login.html')	

@app.route('/home1')
def home1():
   return render_template('home.html')

@app.route('/enternew')
def new_student():
   return render_template('student.html')

@app.route('/list')
def list():
   print (dbHandler.retrieveUsers())
   return render_template("list.html",rows =dbHandler.retrieveUsers())

app.route('/login')
def login():
   return render_template('login.html')




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




	
if __name__ == '__main__':
        app.run(debug=False)
