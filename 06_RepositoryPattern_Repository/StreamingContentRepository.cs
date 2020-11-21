using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
   public class StreamingContentRepository
    {
        //properties are class level variables - define the class as what it can contain
        //field

        private List<StreamingContent> _listOfContent = new List<StreamingContent>(); //variable field

        //Create
        public void AddContentToList(StreamingContent content) //access - void(no return type) - Name of Object(object type)
        {
            _listOfContent.Add(content); // _field.Add(parameter)
        }

        //Read
        public List<StreamingContent> GetContentList() //dont need parameters - we know what list we are pulling
        {
            return _listOfContent;
        }

        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle); //Object newVar = Method(parameter)
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }

            //Update the content
        }


        //Delete (CRUD)
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if( content == null) //is content null? program stops
            {
                return false;
            }

            int initialCount = _listOfContent.Count; //use count method to determine list
            _listOfContent.Remove(content); //use Remove method to remove content

            if(initialCount > _listOfContent.Count) //use count and expression to determine if we now have less titles
            {
                return true; //if we do, true
            }
            else
            {
                return false; //if not, false
            }
        }


        //Helper method
        public StreamingContent GetContentByTitle(string title) //method to find title
        {
            foreach(StreamingContent content in _listOfContent) // loop - foreach(iteminlist) var in _list
            {
                if(content.Title.ToLower() == title.ToLower()) //if statement - var.property == var(defined in previous object)
                {
                    return content;
                }
            }

            return null; //safety return - if no other returns have values
        }
    }

}
