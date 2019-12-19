using System;
using System.ComponentModel.DataAnnotations;

namespace GCS.Models
{
    public class Outcome
    {
        public int Id { get; set; }
        public int Company_id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Assessment_date { get; set; }
        /*public string Outcome_val { get; set; }
        public string Outcome_desc { get; set; }
        public string Type_code { get; set; }
        public string Discipline_code { get; set; }*/
        public string strat_fo_outcome_val_1 { get; set; }
        public string strat_fo_outcome_desc_1 { get; set; }
        public string strat_fo_outcome_val_2 { get; set; }
        public string strat_fo_outcome_desc_2 { get; set; }
        public string strat_fo_outcome_val_3 { get; set; }
        public string strat_fo_outcome_desc_3 { get; set; }
        public string strat_fo_outcome_val_4 { get; set; }
        public string strat_fo_outcome_desc_4 { get; set; }
        public string strat_fo_outcome_val_5 { get; set; }
        public string strat_fo_outcome_desc_5 { get; set; }
        public string strat_ro_outcome_val_1 { get; set; }
        public string strat_ro_outcome_desc_1 { get; set; }
        public string strat_ro_outcome_val_2 { get; set; }
        public string strat_ro_outcome_desc_2 { get; set; }
        public string strat_ro_outcome_val_3 { get; set; }
        public string strat_ro_outcome_desc_3 { get; set; }
        public string strat_ro_outcome_val_4 { get; set; }
        public string strat_ro_outcome_desc_4 { get; set; }
        public string strat_ro_outcome_val_5 { get; set; }
        public string strat_ro_outcome_desc_5 { get; set; }
        public string stake_fo_outcome_val_1 { get; set; }
        public string stake_fo_outcome_desc_1 { get; set; }
        public string stake_fo_outcome_val_2 { get; set; }
        public string stake_fo_outcome_desc_2 { get; set; }
        public string stake_fo_outcome_val_3 { get; set; }
        public string stake_fo_outcome_desc_3 { get; set; }
        public string stake_fo_outcome_val_4 { get; set; }
        public string stake_fo_outcome_desc_4 { get; set; }
        public string stake_fo_outcome_val_5 { get; set; }
        public string stake_fo_outcome_desc_5 { get; set; }
        public string stake_ro_outcome_val_1 { get; set; }
        public string stake_ro_outcome_desc_1 { get; set; }
        public string stake_ro_outcome_val_2 { get; set; }
        public string stake_ro_outcome_desc_2 { get; set; }
        public string stake_ro_outcome_val_3 { get; set; }
        public string stake_ro_outcome_desc_3 { get; set; }
        public string stake_ro_outcome_val_4 { get; set; }
        public string stake_ro_outcome_desc_4 { get; set; }
        public string stake_ro_outcome_val_5 { get; set; }
        public string stake_ro_outcome_desc_5 { get; set; }
        public string oper_fo_outcome_val_1 { get; set; }
        public string oper_fo_outcome_desc_1 { get; set; }
        public string oper_fo_outcome_val_2 { get; set; }
        public string oper_fo_outcome_desc_2 { get; set; }
        public string oper_fo_outcome_val_3 { get; set; }
        public string oper_fo_outcome_desc_3 { get; set; }
        public string oper_fo_outcome_val_4 { get; set; }
        public string oper_fo_outcome_desc_4 { get; set; }
        public string oper_fo_outcome_val_5 { get; set; }
        public string oper_fo_outcome_desc_5 { get; set; }
        public string oper_ro_outcome_val_1 { get; set; }
        public string oper_ro_outcome_desc_1 { get; set; }
        public string oper_ro_outcome_val_2 { get; set; }
        public string oper_ro_outcome_desc_2 { get; set; }
        public string oper_ro_outcome_val_3 { get; set; }
        public string oper_ro_outcome_desc_3 { get; set; }
        public string oper_ro_outcome_val_4 { get; set; }
        public string oper_ro_outcome_desc_4 { get; set; }
        public string oper_ro_outcome_val_5 { get; set; }
        public string oper_ro_outcome_desc_5 { get; set; }
        public string risk_fo_outcome_val_1 { get; set; }
        public string risk_fo_outcome_desc_1 { get; set; }
        public string risk_fo_outcome_val_2 { get; set; }
        public string risk_fo_outcome_desc_2 { get; set; }
        public string risk_fo_outcome_val_3 { get; set; }
        public string risk_fo_outcome_desc_3 { get; set; }
        public string risk_fo_outcome_val_4 { get; set; }
        public string risk_fo_outcome_desc_4 { get; set; }
        public string risk_fo_outcome_val_5 { get; set; }
        public string risk_fo_outcome_desc_5 { get; set; }
        public string risk_ro_outcome_val_1 { get; set; }
        public string risk_ro_outcome_desc_1 { get; set; }
        public string risk_ro_outcome_val_2 { get; set; }
        public string risk_ro_outcome_desc_2 { get; set; }
        public string risk_ro_outcome_val_3 { get; set; }
        public string risk_ro_outcome_desc_3 { get; set; }
        public string risk_ro_outcome_val_4 { get; set; }
        public string risk_ro_outcome_desc_4 { get; set; }
        public string risk_ro_outcome_val_5 { get; set; }
        public string risk_ro_outcome_desc_5 { get; set; }
    }
}
