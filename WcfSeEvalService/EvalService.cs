using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfSeEvalService
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single)]
    class EvalService : IEvalService
    {
        List<Eval> evals = new List<Eval>();
        public List<Eval> GetEval()
        {
            return evals;
        }

        public void RemoveEval(int Id)
        {
            evals.Remove(evals.Find(e=>e.Id.Equals(Id)));
        }

        public void SubmitEval(Eval eval)
        {
           int ud= eval.Id ;
            for (int i = 0; i < ud; i++)
            {
                if (i == ud)
                {
                    i++;
                }

            }
                evals.Add(eval);
            
            
            
        }
    }
}
