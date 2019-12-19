using System;
using System.ComponentModel.DataAnnotations;

namespace GCS.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public int Company_id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Assessment_date { get; set; }
        public string Vision_agreement { get; set; }
        public string Core_values_agreement { get; set; }
        public string Mission_statement_agreement { get; set; }
        public string Vision_outcome_agreement { get; set; }
        public string Competitive_strategy_agreement { get; set; }
        public string Company_composite_score { get; set; }
        public string Strat_people_score { get; set; }
        public string Strat_resources_score { get; set; }
        public string Strat_processes_score { get; set; }
        public string Strat_culture_score { get; set; }
        public string Strat_composite_score { get; set; }
        public string Stake_people_score { get; set; }
        public string Stake_resources_score { get; set; }
        public string Stake_processes_score { get; set; }
        public string Stake_culture_score { get; set; }
        public string Stake_composite_score { get; set; }
        public string Oper_people_score { get; set; }
        public string Oper_resources_score { get; set; }
        public string Oper_processes_score { get; set; }
        public string Oper_culture_score { get; set; }
        public string Oper_composite_score { get; set; }
        public string Risk_people_score { get; set; }
        public string Risk_resources_score { get; set; }
        public string Risk_processes_score { get; set; }
        public string Risk_culture_score { get; set; }
        public string Risk_composite_score { get; set; }
    }
}
