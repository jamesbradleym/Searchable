using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace Searchable
{
  public static class Searchable
  {
    /// <summary>
    /// The Searchable function.
    /// </summary>
    /// <param name="model">The input model.</param>
    /// <param name="input">The arguments to the execution.</param>
    /// <returns>A SearchableOutputs instance containing computed results and the model with any new elements.</returns>
    public static SearchableOutputs Execute(Dictionary<string, Model> inputModels, SearchableInputs input)
    {
      // Your code here.
      var output = new SearchableOutputs();

      foreach (var elevation in Enumerable.Range(0, input.LevelCount))
      {
        var level = new Level
        {
          Elevation = elevation * 3,
          Height = 3,
          Name = $"Level {elevation}"
        };

        output.Model.AddElement(level);
      }

      return output;
    }
  }
}