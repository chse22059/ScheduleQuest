using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class CalendarManager : MonoBehaviour {

    DateTime now;                  //現在日
    DayOfWeek firstDate;           //月初の曜日

    public GameObject YearText;    //年テキスト
    public GameObject MonthText;   //月テキスト
    public GameObject[] DayText;   //日付テキスト

    private int year;              //年
    private int month;             //月
    private int day;               //日

    private int days;              //テキストに代入する日付


    // Use this for initialization
    void Start () {
        SearchYears();
        RewriteText();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    //現在日から月初の曜日を割り出す
    void SearchYears()
    {
        now = DateTime.Now;
        year = now.Year;          //現年度
        month = now.Month;        //現月度
        day = now.Day;            //現日付

        DateTime firstDay = new DateTime(year,month , 1);
        firstDate = firstDay.DayOfWeek;
    }


    //年・月・日のテキストを書き替える
    void RewriteText()
    {
    // 年と月を設定
    YearText.GetComponent<TextMeshProUGUI>().text = year.ToString();
    MonthText.GetComponent<TextMeshProUGUI>().text = month.ToString();

    // 月の最終日を取得
    int monthEnd = DateTime.DaysInMonth(year, month);

    // 月初の曜日のオフセット
    int firstDayOffset = (int)firstDate;

    // 次月の年と月を計算
    int nextMonth = (month == 12) ? 1 : month + 1;
    int nextYear = (month == 12) ? year + 1 : year;

    // 現在の月の日付を埋める
    int dayCounter = 1; // 現在の月の日付
    for (int i = 0; i < 37; i++)
    {
        if (i >= firstDayOffset && dayCounter <= monthEnd)
        {
            // 現在の月の日付を設定
            DayText[i].GetComponent<TextMeshProUGUI>().text = dayCounter.ToString();
            dayCounter++;
        }
        else if (i >= firstDayOffset + monthEnd)
        {
            // 次月の日付を設定
            int nextMonthDay = i - (firstDayOffset + monthEnd) + 1;
            DayText[i].GetComponent<TextMeshProUGUI>().text = nextMonthDay.ToString();
        }
        else
        {
            // 空白セル（現在の月の前）
            DayText[i].GetComponent<TextMeshProUGUI>().text = "";
        }
    }
    }
}