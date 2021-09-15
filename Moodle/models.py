import sqlite3 as sql


def retrieveUsers():
    con = sql.connect("moodle.db")
    cur = con.cursor()
    cur.execute("SELECT username, password,firstname, lastname, role FROM users")
    users = cur.fetchall()
    con.close()
    return users
