using System.Collections.Generic;
using AdventOfCode2020.Models.Day4;

namespace AdventOfCode2020.Models 
{
    public class Day4Input
    {
        private readonly IList<string> RequiredFields = new List<string> { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

        private readonly IList<string> OptionalFields = new List<string> { "cid" };

        private readonly IList<IValidator> Validators = new List<IValidator> { new BirthYearValidator(), new ExpirationYearValidator(), new EyeColorValidator(), new HairColorValidator(), new HeightValidator(), new IssueYearValidator(), new PassportIdValidator() };

        public Day4Input()
        {
            Fields = new Dictionary<string, string>();
        }

        public IDictionary<string, string> Fields { get; set; }

        public bool IsValidPassport
        {
            get 
            {
                var isValid = true;
                foreach(var field in RequiredFields)
                {
                    if(Fields.ContainsKey(field) == false) 
                    {
                        isValid = false;
                        break;
                    }
                }

                return isValid;
            }
        }

        public bool PassportFieldsAreValid
        {
            get 
            {
                if(IsValidPassport)
                {
                    var valid = true;
                    foreach(var validator in Validators)
                    {
                        if(Fields.TryGetValue(validator.Key, out var value)) 
                        {
                            valid = validator.Validate(value);
                        }

                        if(valid == false)
                        {
                            break;
                        }
                    }

                    return valid;
                }

                return false;
            }
        }
    }
}