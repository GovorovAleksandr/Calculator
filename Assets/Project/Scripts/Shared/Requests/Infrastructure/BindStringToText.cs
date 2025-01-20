using Requests.Public;
using TMPro;

namespace Requests.Infrastructure
{
    public struct BindStringToText : IRequest
    {
        public readonly string String;
        public readonly TextMeshProUGUI Text;

        public bool IsSuccess;

        public BindStringToText(string s, TextMeshProUGUI text) : this()
        {
            String = s;
            Text = text;
        }
    }
}