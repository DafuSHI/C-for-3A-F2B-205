using System;
using System.Collections.Generic;

namespace RemotingInterface
{
    /// <summary>
    /// cette interface contiendra la d�claration de toutes les 
    /// m�thodes de l'objet distribu�
    /// </summary>
    [Serializable]
    public class Data
    {
        public bool error;
        public List<string> users;
        public List<string> messages;

        public Data()
        {
            users = new List<string>();
            messages = new List<string>();
            error = false;
        }

        public List<string> getUsers()
        {
            return users;
        }

        public List<string> getMessages()
        {
            return messages;
        }

        public void addUser(string name)
        {
            users.Add(name);
        }

        public void addMessage(string name,string message)
        {
            messages.Add(name + ": " + message);
        }

    }
    public interface IRemotChaine
	{
        string Hello();

        Data Fresh();
        Data SendMessage(string name,string message);
        Data Login(string Username);
        /* user disconnect. Return true if successful, false elsewise */
        void Disconnect(string name);
    }
}
