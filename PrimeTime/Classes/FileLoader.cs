using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Reflection;
using PrimeTime.Interview.App.Helpers;
using PrimeTime.Interview.App.Enumerations;


namespace PrimeTime.Interview.App.Classes
{

    /// <summary>
    /// This class is used for working with input file
    /// </summary>
    class FileLoader
    {

        // private vars 
        private string _sourceFileName;
        private string _filePath;
        private string[] _content;
        private string _fullpath;

        // properties
        public string[] content
        {
            get{ return _content; }
         
        }

        //Constructor
        public FileLoader()
        {

            //init directory path based on current working directory and configured folder. 
            _filePath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName + "//" + ConfigurationManager.AppSettings["InputFileDirectoryName"].ToString() + "//";

            //request file for processing 
            prepareForFile(Prompts.AskforFile);

            //ensure we have a valid file before continuing
            while (!isValid()){ prepareForFile(Prompts.InValidFile); }//re-request file for processing

            // load file data once valid
            loadfile();


        }

        // returns content from file into array
        private void loadfile()
        {
            
            _content = System.IO.File.ReadAllLines(_fullpath);

        }

        // check to see if file is found on disk. 
        private bool isValid()
        {

          return (!System.IO.File.Exists(_fullpath))? false:true;
         
        }//end is Valid

      
        //builds the full file path
        private void buildFilePath()
        {
  
            _fullpath = @_filePath + _sourceFileName;

        }

        //  request info from user and setup file for processing..keeping it DRY. 
        private void prepareForFile(Prompts p)
        {

            //Prompt for file name; 
            Util.sendPrompts(p);

            // Get user input 
            _sourceFileName = Util.getInput();

            // Build full path to file. 
            buildFilePath();


        }
      
    }

}
