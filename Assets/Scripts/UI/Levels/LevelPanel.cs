using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelPanel : MonoBehaviour
{
    public LevelInfo info;
    public TMP_Text Title;
    public TMP_Text Duration;

    private void Start()
    {
        info = new LevelInfo();
    }
    public void OnClick()
    {
        EditLevels editor = EditLevels.Instance;
        editor.curPanel = this;
        editor.SwitchToLevel();

        //TODO : 将数据添加回levelEditor里
    }

    public void Delete()
    {
        EditLevels editor = EditLevels.Instance;
        editor.DeleteButton(this);
    }

    public LevelInfo GetLevelInfo()
    {
        return info;
    }

    public void UpdatePanel(string title, string duration)
    {
        Title.text = title;
        Duration.text = duration;
    }
}
